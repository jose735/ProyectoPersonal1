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
    public partial class InicioSesion : Form
    {
        public static String nombreDeUsuario = "";
        public static String nombreUsuario = "";
        public static int tipoDeUsuario = 0;
        public static Boolean ind2 = false;
        public InicioSesion()
        {
            InitializeComponent();
        }

        private void txtNombreUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtContrasenna.Focus();
            }
        }

        private void txtContrasenna_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnIniciarSesion.Focus();
            }
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            UsuarioLogica usuarioL = new UsuarioLogica();

            if (txtNombreUsuario.Text == "" || txtContrasenna.Text == "")
            {
                lblMensaje.Text = "Por favor, complete los campos necesarios de nombre de usuario y contraseña";
            }
            else
            {
                if (usuarioL.ObtenerUsuario(txtNombreUsuario.Text, txtContrasenna.Text).Count > 0)
                {
                    Usuario u = new Usuario();
                    u = usuarioL.ObtenerUsuario(txtNombreUsuario.Text, txtContrasenna.Text).ElementAt(0);
                    nombreDeUsuario = u.nombreCompleto;
                    nombreUsuario = u.nombreUsuario;
                    tipoDeUsuario = u.idTipoUsuario;
                    ind2 = true;
                    Principal p = new Principal();
                    p.Show();
                    this.Hide();
                }
                else
                {
                    lblMensaje.Text = "Usuario o contraseña invalidos";
                }
            }
        }

        private void InicioSesion_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Focus();
            Principal.ind = false;
        }

        private void InicioSesion_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
        }

        private void InicioSesion_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Principal.ind == false)
            {
                if (MessageBox.Show("Desea salir de esta aplicación?", "Sisfacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    Principal.ind = true;
                    Application.Exit();
                }
            }
        }

        private void lblCambiarContrasenna_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ind2 = false;
            CambiarContrasenna c = new CambiarContrasenna();
            c.ShowDialog();
        }
    }
}
