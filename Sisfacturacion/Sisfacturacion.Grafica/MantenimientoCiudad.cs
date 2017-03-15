using Sisfacturacion.Entidades;
using Sisfacturacion.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sisfacturacion.Grafica
{
    public partial class MantenimientoCiudad : Form
    {
        CiudadLogica cL = new CiudadLogica();
        public MantenimientoCiudad()
        {
            InitializeComponent();
        }

        public void LimpiarCampos()
        {
            txtCodigoCiudad.Text = "";
            txtNombreCiudad.Text= "";
            cboEstado.SelectedIndex = 0;
        }

        public void refrescar()
        {
            dgvCiudades.DataSource = cL.ObtenerTodosCiudad(1);
        }

        public void cargarCombo()
        {
            cboEstado.Items.Add("Seleccionar Estado");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.Items.Add("Todos");
        }

        private void MantenimientoCiudad_Load(object sender, EventArgs e)
        {
            tiempoCarga.Start();
            tiempoCarga.Interval = cL.ObtenerTodosCiudad(1).Count * 25;
            dgvCiudades.AutoGenerateColumns = false;
            cargarCombo();
            //refrescar();
            LimpiarCampos();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnInsertarCiudad_Click(object sender, EventArgs e)
        {
            //verificar si los campos estan nulos
            if (txtCodigoCiudad.Text == "" || txtNombreCiudad.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su registro";
            }
            else
            {
                //se verifica si la ciudad ya esixte y se lo informa al usuario
                if (cL.ObtenerCiudad(Convert.ToInt32(txtCodigoCiudad.Text)).Count > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Lo sentimos, la ciudad que va a registrar ya esta ingresada en el sistema";
                }
                else
                {
                    //crea la instancia de ciudad
                    Ciudad c = new Ciudad();
                    c.idCiudad = Convert.ToInt32(txtCodigoCiudad.Text);
                    c.descripcion = txtNombreCiudad.Text;
                    c.estado = 1;

                    //inserta la ciudad
                    cL.InsertarCiudad(c);
                    refrescar();
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Ciudad registrada exitosamente";
                }
            }
        }

        private void btnModificarCiudad_Click(object sender, EventArgs e)
        {
            if (txtCodigoCiudad.Text == "" || txtNombreCiudad.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su modificación";
            }
            else
            {
                Ciudad c1 = (Ciudad)dgvCiudades.Rows[dgvCiudades.SelectedRows[0].Index].DataBoundItem;

                //crea la instancia del objeto ciudad
                Ciudad c = new Ciudad();
                c.idCiudad = c1.idCiudad;
                c.descripcion = txtNombreCiudad.Text;


                if (cboEstado.SelectedIndex == 0)
                {
                    c.estado = c1.estado;
                }

                if (cboEstado.SelectedIndex == 1)
                {
                    c.estado = 1;
                }

                if (cboEstado.SelectedIndex == 2)
                {
                    if (cL.ObtenerCiudadPorProveedor(Convert.ToInt32(txtCodigoCiudad.Text)) > 0)
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "Lo sentimos, no se puede cambiar el estado debido a que tiene un proveedor asignado";
                        return;
                    }
                    else
                    {
                        c.estado = 2;
                    }
                }

                if (cboEstado.SelectedIndex == 3)
                {
                    c.estado = c1.estado;
                }

                //modifica la ciudad y lo muestra en el datagridview
                cL.ModificarCiudad(c);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "La ciudad fue modificada exitosamente";
            }
        }

        private void btnMostrarEstado_Click(object sender, EventArgs e)
        {
            //verifica que se haya seleccionado una opcion
            if (cboEstado.SelectedIndex == 0)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, seleccione un estado";
            }

            //selecciona las ciudades activas
            if (cboEstado.SelectedIndex == 1)
            {
                dgvCiudades.DataSource = null;
                dgvCiudades.DataSource = cL.ObtenerTodosCiudad(1);
            }

            //selecciona las ciudades inactivas
            if (cboEstado.SelectedIndex == 2)
            {
                dgvCiudades.DataSource = null;
                dgvCiudades.DataSource = cL.ObtenerTodosCiudad(2);
            }

            //selecciona todas las ciudades
            if (cboEstado.SelectedIndex == 3)
            {
                dgvCiudades.DataSource = null;
                dgvCiudades.DataSource = cL.ObtenerTodosCiudad();
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void MantenimientoCiudad_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void btnEliminarCiudad_Click(object sender, EventArgs e)
        {
            //verifica que hayan campos vacios y se lo informa al usuario
            if (txtCodigoCiudad.Text == "" || txtNombreCiudad.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, llene los campos necesarios para realizar su eliminación";
            }
            else
            {
                //elimina a la ciudad
                if (cL.ObtenerCiudadPorProveedor(Convert.ToInt32(txtCodigoCiudad.Text)) > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Lo sentimos, no se puede eliminar a esta ciudad debido a que tiene un proveedor asignado";
                }
                else
                {
                    Ciudad c1= (Ciudad)dgvCiudades.Rows[dgvCiudades.SelectedRows[0].Index].DataBoundItem;
                    Ciudad c = new Ciudad();
                    c.idCiudad = Convert.ToInt32(txtCodigoCiudad.Text);
                    c.descripcion = c1.descripcion;
                    c.estado = 2;
                    cL.ModificarCiudad(c);
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Ciudad eliminada exitosamente";
                    refrescar();
                }
            }
        }

        private void dgvCiudad_SelectionChanged(object sender, EventArgs e)
        {
            
        }

        private void dgvCiudades_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si la fila ha sido seleccionada
            if (dgvCiudades.SelectedRows.Count > 0)
            {
                //obtiene el objeto de la fila seleccionada
                Ciudad c = (Ciudad)dgvCiudades.Rows[dgvCiudades.SelectedRows[0].Index].DataBoundItem;

                txtCodigoCiudad.Text = c.idCiudad.ToString();
                txtNombreCiudad.Text = c.descripcion;

                //obtiene el estado seleccionado
                for (int i = 0; i < cboEstado.Items.Count; i++)
                {
                    String estado = cboEstado.Items[i].ToString();
                    if (c.nombreEstado == estado)
                    {
                        cboEstado.SelectedIndex = i;
                    }
                }
            }
        }

        private void tiempoCarga_Tick(object sender, EventArgs e)
        {
            pbCarga.Increment(1);
            lblPorcentaje.Text = pbCarga.Value.ToString() + "%";
            if (pbCarga.Value == 100)
            {
                dgvCiudades.DataSource = cL.ObtenerTodosCiudad(1);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Carga de ciudades realizada exitosamente";
                pbCarga.Visible = false;
                tiempoCarga.Stop();
                lblPorcentaje.Text = "";

            }
        }
    }
}
