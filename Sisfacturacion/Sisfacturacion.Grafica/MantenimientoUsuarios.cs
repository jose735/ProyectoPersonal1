using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sisfacturacion.Entidades;
using Sisfacturacion.Logica;

namespace Sisfacturacion.Grafica
{
    public partial class MantenimientoUsuarios : Form
    {
        TipoUsuarioLogica tipoU = new TipoUsuarioLogica();
        UsuarioLogica uL = new UsuarioLogica();
        public MantenimientoUsuarios()
        {
            InitializeComponent();
        }

        private void MantenimientoUsuarios_Load(object sender, EventArgs e)
        {
            //no genera columnas de manera automatica
            dgvUsuarios.AutoGenerateColumns = false;
            refrescar();
            limpiarCampos();
        }

        public void refrescar()
        {
            //Carga el combo de tipos de usuario
            cboTipoUsuario.DataSource = tipoU.ObtenerTodosUsuarios();
            cboTipoUsuario.DisplayMember = "descripcion";
            cboTipoUsuario.ValueMember = "idTipoUsuario";

            //Carga el datagridview de usuarios
            dgvUsuarios.DataSource = uL.ObtenerTodosUsuarios();

        }


        //limpia el valor de todos los campos
        public void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContrasenna.Text = "";
            txtNombreCompleto.Text = "";
            cboTipoUsuario.SelectedIndex = 0;
            lblMensaje.Text = "";
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si la fila ha sido seleccionada
            if (dgvUsuarios.SelectedRows.Count > 0)
            {
                //obtiene el objeto de la fila seleccionada
                Usuario u = (Usuario) dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].DataBoundItem;

                txtNombreUsuario.Text = u.nombreUsuario;
                txtNombreCompleto.Text = u.nombreCompleto;
                txtContrasenna.Text = u.contrasenna;

                //selecciona la opcion del combo de tipo de usuario
                if (u.nombreTipoUsuario == "Administrador")
                {
                    cboTipoUsuario.SelectedIndex = 0;
                }

                if (u.nombreTipoUsuario == "Supervisor")
                {
                    cboTipoUsuario.SelectedIndex = 1;
                }

                if (u.nombreTipoUsuario == "Cajero")
                {
                    cboTipoUsuario.SelectedIndex = 2;
                }
            }
        }

        private void btnInsertarUsuario_Click(object sender, EventArgs e)
        {
            //verifica que no hayan campos vacios
            if (txtNombreUsuario.Text == "" || txtContrasenna.Text == "" || txtNombreCompleto.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, llene los campos necesarios para realizar su registro";
            }
            else
            {
                //verifica que el usuario ya exista y se lo informa al usuario
                if (uL.ObtenerUsuario(txtNombreUsuario.Text).Count > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Lo sentimos, ya existe un usuario con estos datos, por favor ingrese otro";
                }
                else
                {
                    //crea el objeto usuario
                    Usuario u = new Usuario();
                    u.nombreUsuario = txtNombreUsuario.Text;
                    u.contrasenna = txtContrasenna.Text;
                    u.nombreCompleto = txtNombreCompleto.Text;
                    u.idTipoUsuario = Convert.ToInt32(cboTipoUsuario.SelectedValue);

                    //inserta al usuario
                    uL.InsertarUsuario(u);
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Usuario registrado exitosamente";
                    refrescar();
                }
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            //verifica que hayan campos vacios y se lo informa al usuario
            if (txtNombreUsuario.Text == "" || txtContrasenna.Text == "" || txtNombreCompleto.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, llene los campos necesarios para realizar su eliminación";
            }
            else
            {
                //elimina al usuario
                uL.EliminarUsuario(txtNombreUsuario.Text);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Usuario eliminado exitosamente";
                refrescar();
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
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

        private void MantenimientoUsuarios_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }
    }
}
