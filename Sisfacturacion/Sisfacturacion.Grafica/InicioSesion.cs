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
        CajaLogica cl = new CajaLogica();
        public static String nombreDeCaja = "";
        public static int codigoCaja = 0;
        public static String nombreDeUsuario = "";
        public static String nombreUsuario = "";
        public static int tipoDeUsuario = 0;
        public static Boolean ind2 = false;
        public static Boolean AdminSuperv = false;
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
                    Usuario u1 = usuarioL.ObtenerUsuario(txtNombreUsuario.Text, txtContrasenna.Text).ElementAt(0);
                    if (u1.estado == 2)
                    {
                        lblMensaje.Text = "Usuario inactivo, no puede iniciar sesión, por favor, active su cuenta";
                    }
                    else
                    {
                        Usuario u = new Usuario();
                        u = usuarioL.ObtenerUsuario(txtNombreUsuario.Text, txtContrasenna.Text).ElementAt(0);
                        nombreDeUsuario = u.nombreCompleto;
                        nombreUsuario = u.nombreUsuario;
                        tipoDeUsuario = u.idTipoUsuario;
                        ind2 = true;
                        //verifica que el usuario sea cajero y si tiene asignada mas de una caja
                        if (usuarioL.ObtenerCajaPorUsuario2(nombreUsuario).Count > 1)
                        {
                            SeleccionCaja s = new SeleccionCaja();
                            s.Show();
                            this.Hide();
                        }
                        else
                        {
                            //verifica que el usuario sea cajero y si tiene asignada una caja
                            if (usuarioL.ObtenerCajaPorUsuario2(nombreUsuario).Count == 1)
                            {
                                codigoCaja = usuarioL.ObtenerCajaPorUsuario2(nombreUsuario).ElementAt(0).idCaja;
                                nombreDeCaja = usuarioL.ObtenerCajaPorUsuario2(nombreUsuario).ElementAt(0).descripcion;
                                Principal p = new Principal();
                                p.Show();
                                this.Hide();
                            }
                            else
                            {
                                //verifica que el usuario sea diferente de cajero y se dispone a selecciona la caja a utilizar
                                if (usuarioL.ObtenerCajaPorUsuario2(nombreUsuario).Count < 1)
                                {
                                    AdminSuperv = true;
                                    SeleccionCaja s = new SeleccionCaja();
                                    s.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
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

            //Los controles y los mensajes que se van a mostrar en los controles asignados
            hpAyuda.SetShowHelp(this.txtNombreUsuario, true);
            hpAyuda.SetHelpString(this.txtNombreUsuario, "Se ingresa el nombre de usuario suministrado por el administrador");
            hpAyuda.SetShowHelp(this.txtContrasenna, true);
            hpAyuda.SetHelpString(this.txtContrasenna, "La contraseña debe contener letras y al menos un número");

            tltAyuda.AutoPopDelay = 5000;
            tltAyuda.InitialDelay = 500;
            tltAyuda.ReshowDelay = 500;
            tltAyuda.ShowAlways = true;
            tltAyuda.SetToolTip(this.txtNombreUsuario, "Se ingresa el nombre de usuario suministrado por el administrador");
            tltAyuda.SetToolTip(this.txtContrasenna, "La contraseña debe contener letras y al menos un número");
            tltAyuda.SetToolTip(this.btnIniciarSesion, "Ingresa al sistema el nombre y la contraseña digitados");
            tltAyuda.SetToolTip(this.lblCambiarContrasenna, "Cambia la contraseña de la persona que va a ingresar");

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
