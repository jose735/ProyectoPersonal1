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
    public partial class MantenimientoCajas : Form
    {
        UsuarioLogica uL = new UsuarioLogica();
        CajaLogica cL = new CajaLogica();
        public MantenimientoCajas()
        {
            InitializeComponent();
        }

        public void refrescar()
        {
            //carga el combo con los nombres completos de los usuarios
            cboUsuarios.DataSource = uL.ObtenerTodosUsuarios2();
            cboUsuarios.DisplayMember = "nombreCompleto";
            cboUsuarios.ValueMember = "idUsuario";

            //carga de todas las cajas en el datagridview
            dgvCajas.DataSource = cL.ObtenerTodosCajas();
        }

        public void limpiarCampos()
        {
            txtDescripcion.Text = "";
            cboUsuarios.SelectedIndex = 0;
            lblMensaje.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnInsertarCaja_Click(object sender, EventArgs e)
        {
            //verificar que el campo de descripcion este vacio
            if (txtDescripcion.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, llene los campos necesarios para realizar su registro";
            }
            else
            {
                //crea la instancia del objeto caja
                Caja c = new Caja();
                c.descripcion = txtDescripcion.Text;
                c.idUsuario = Convert.ToInt32(cboUsuarios.SelectedValue);

                //inserta la caja y lo muestra en el datagridview
                cL.InsertarCaja(c);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Caja registrada exitosamente";
            }
        }

        private void btnModificarCaja_Click(object sender, EventArgs e)
        {
            //verificar que el campo de descripcion este vacio
            if (txtDescripcion.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, llene los campos necesarios para realizar su modificación";
            }
            else
            {
                //crea la instancia del objeto caja
                Caja c = new Caja();
                c.descripcion = txtDescripcion.Text;
                c.idUsuario = Convert.ToInt32(cboUsuarios.SelectedValue);
                c.idCaja = cL.ObtenerCaja(txtDescripcion.Text).ElementAt(0).idCaja;

                //modifica la caja y lo muestra en el datagridview
                cL.ModificarCaja(c);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "La caja fue modificada exitosamente";
            }
        }

        private void btnEliminarCaja_Click(object sender, EventArgs e)
        {
            //verificar que el campo de descripcion este vacio
            if (txtDescripcion.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, llene los campos necesarios para realizar su eliminación";
            }
            else
            {
                //elimina la caja y lo muestra en el datagridview
                cL.EliminarCaja(txtDescripcion.Text);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "La caja fue eliminada exitosamente";
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void dgvCajas_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si la fila ha sido seleccionada
            if (dgvCajas.SelectedRows.Count > 0)
            {
                //obtiene el objeto de la fila seleccionada
                Caja c = (Caja)dgvCajas.Rows[dgvCajas.SelectedRows[0].Index].DataBoundItem;

                txtDescripcion.Text = c.descripcion;

                for (int i= 0; i < cboUsuarios.Items.Count; i++)
                {
                    Usuario u = (Usuario) cboUsuarios.Items[i];
                    if (u.nombreCompleto == c.nombreCompleto)
                    {
                        cboUsuarios.SelectedIndex = i;
                    }
                }
            }
        }

        private void MantenimientoCajas_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void MantenimientoCajas_Load(object sender, EventArgs e)
        {
            dgvCajas.AutoGenerateColumns = false;
            refrescar();
            limpiarCampos();
        }

        private void MantenimientoCajas_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }
    }
}
