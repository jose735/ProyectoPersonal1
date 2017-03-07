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
    public partial class Principal : Form
    {
        public static Boolean ind = false;
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Text += InicioSesion.nombreDeUsuario;
            if (InicioSesion.tipoDeUsuario == 2)
            {
                relacionadoAArtículosToolStripMenuItem.Enabled = false;
                clientesToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = false;
            }
            if (InicioSesion.tipoDeUsuario == 3)
            {
                mantenimientoToolStripMenuItem.Enabled = false;
                devolucionesToolStripMenuItem.Enabled = false;
                reportesToolStripMenuItem.Enabled = false;
            }
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoUsuarios mu = new MantenimientoUsuarios();
            mu.Show();
            this.Hide();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            //if (MessageBox.Show("Desea salir de esta aplicación?", "Sisfacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    Application.Exit();
            //}
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            //cierra completamente la aplicación si el usuario selecciona que sí
            if (ind == false)
            {
                if (MessageBox.Show("Desea salir de esta aplicación?", "Sisfacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    e.Cancel = true;
                }
                else
                {
                    InicioSesion.ind2 = false;//es para poder volver a entrar de manera normal al cambiar contraseña
                    ind = true;
                    Application.Exit();
                }
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //cierra la sesion del usuario si el usuario selecciona que sí
            if (ind == false)
            {
                if (MessageBox.Show("Desea cerrar esta sesión, " + InicioSesion.nombreDeUsuario +" ?", "Sisfacturacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    InicioSesion.ind2 = false;//es para poder volver a entrar de manera normal al cambiar contraseña
                    InicioSesion i = new InicioSesion();
                    i.Show();
                    this.Hide();
                }
            }
        }

        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            InicioSesion.ind2 = true;
            CambiarContrasenna cc = new CambiarContrasenna();
            cc.ShowDialog();
        }

        private void cajasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCajas mc = new MantenimientoCajas();
            mc.Show();
            this.Hide();
        }

        private void ciudadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MantenimientoCiudad mc = new MantenimientoCiudad();
            mc.Show();
            this.Hide();
        }
    }
}
