using Sisfacturacion.Logica;
using Sisfacturacion.Entidades;
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
    public partial class MantenimientoClientes : Form
    {
        ClienteLogica cl = new ClienteLogica();

        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        public void refrescar()
        {
            //carga del grid de clientes
            dgvClientes.DataSource = cl.ObtenerTodosCliente();
        }

        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            lblMensaje.Text = "";
        }

        private void MantenimientoClientes_Load(object sender, EventArgs e)
        {
            tiempoCarga.Start();
            tiempoCarga.Interval = cl.ObtenerTodosCliente().Count * 5;

            //alterna colores en la filas del datagridview
            dgvClientes.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvClientes.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            dgvClientes.AutoGenerateColumns = false;
            //refrescar();
            limpiarCampos();

            //Los controles y los mensajes que se van a mostrar en los controles asignados
            hpAyuda.SetShowHelp(this.txtCodigo, true);
            hpAyuda.SetHelpString(this.txtCodigo, "El número de identificación debe contener 9 digitos sin espacios");
            hpAyuda.SetShowHelp(this.txtDireccion, true);
            hpAyuda.SetHelpString(this.txtDireccion, "Se debe escribir la direccion exacta de la casa de habitación");
            hpAyuda.SetShowHelp(this.txtNombre, true);
            hpAyuda.SetHelpString(this.txtNombre, "El nombre debe contener los dos nombres y apellidos");
            hpAyuda.SetShowHelp(this.txtTelefono, true);
            hpAyuda.SetHelpString(this.txtTelefono, "El telefono debe contener 8 digitos sin espacios ni letras");

            //configuracion de tiempo de respuesta del tooltip
            tltHerramientas.AutoPopDelay = 5000;
            tltHerramientas.InitialDelay = 500;
            tltHerramientas.ReshowDelay = 500;

            //configura que el tooltip se muestre siempre
            tltHerramientas.ShowAlways = true;

            //configura a cuales controles se va a mostrar y el mensaje que se mostrará
            tltHerramientas.SetToolTip(this.txtCodigo, "El número de identificación debe contener 9 digitos sin espacios");
            tltHerramientas.SetToolTip(this.txtDireccion, "Se debe escribir la direccion exacta de la casa de habitación");
            tltHerramientas.SetToolTip(this.txtNombre, "El nombre debe contener los dos nombres y apellidos");
            tltHerramientas.SetToolTip(this.txtTelefono, "El telefono debe contener 8 digitos sin espacios ni letras");
            tltHerramientas.SetToolTip(this.btnLimpiarCampos, "Deja los campos de texto vacios para nuevos datos");
            tltHerramientas.SetToolTip(this.btnMenuPrincipal, "Sale de este mantenimiento y se regresa al menu principal");
            tltHerramientas.SetToolTip(this.btnModificarCliente, "Modifica los datos registrados del cliente");
        }

        private void MantenimientoClientes_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            limpiarCampos();
        }

        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtDireccion.Text == "" || txtNombre.Text == "" || txtTelefono.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su registro";
            }
            else
            {
                Cliente c1 = (Cliente)dgvClientes.Rows[dgvClientes.SelectedRows[0].Index].DataBoundItem;

                //Crear la instancia de cliente
                Cliente c = new Cliente();
                c.idCliente = c1.idCliente;
                c.nombre = c1.nombre;
                c.telefono = txtTelefono.Text;
                c.direccion = txtDireccion.Text;

                //modificar cliente
                cl.ModificarCliente(c);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Cliente modificado exitosamente";
            }
        }

        private void dgvClientes_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si la fila ha sido seleccionada
            if (dgvClientes.SelectedRows.Count > 0)
            {
                //obtiene el objeto de la fila seleccionada
                Cliente c1 = (Cliente) dgvClientes.Rows[dgvClientes.SelectedRows[0].Index].DataBoundItem;

                txtCodigo.Text = c1.idCliente;
                txtDireccion.Text = c1.direccion;
                txtNombre.Text = c1.nombre;
                txtTelefono.Text = c1.telefono;
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void tiempoCarga_Tick(object sender, EventArgs e)
        {
            pbCarga.Increment(1);
            dgvClientes.Enabled = false;
            lblPorcentaje.Text = pbCarga.Value.ToString() + "%   Cargando datos de clientes, espere por favor";
            if (pbCarga.Value == 100)
            {
                dgvClientes.DataSource = cl.ObtenerTodosCliente();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Carga de clientes realizada exitosamente";
                pbCarga.Visible = false;
                dgvClientes.Enabled = true;
                tiempoCarga.Stop();
                lblPorcentaje.Text = "";

            }
        }
    }
}
