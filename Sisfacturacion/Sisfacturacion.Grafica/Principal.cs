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
                    InicioSesion i = new InicioSesion();
                    i.Show();
                    this.Hide();
                }
            }
        }
    }
}
