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
        }
    }
}
