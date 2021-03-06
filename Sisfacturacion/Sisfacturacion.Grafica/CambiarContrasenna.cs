﻿using Sisfacturacion.Entidades;
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
    public partial class CambiarContrasenna : Form
    {
        UsuarioLogica uL = new UsuarioLogica();
        public CambiarContrasenna()
        {
            InitializeComponent();
        }

        private void btnCambiarContrasenna_Click(object sender, EventArgs e)
        {
            //verifica que hayan campos nulos
            if (txtNombreUsuario.Text == "" || txtContrasennaActual.Text == "" || txtNuevaContrasenna.Text == "" || txtConfirmarContrasenna.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondiente para realizar el cambio de contraseña";
            }
            else
            {
                //verifica que exista el usuario con la contraseña digitada
                if (uL.ObtenerUsuario(txtNombreUsuario.Text, txtContrasennaActual.Text).Count > 0)
                {
                    //se verifica que la nueva contraseña y la contraseña confirmada sean las mismas
                    if (txtConfirmarContrasenna.Text == txtNuevaContrasenna.Text)
                    {
                        //se crea el objeto usuario
                        Usuario u = new Usuario();
                        u.nombreUsuario = txtNombreUsuario.Text;
                        u.contrasenna = txtConfirmarContrasenna.Text;

                        //se modifica la contraseña y se muestra el mensaje
                        uL.ModificarUsuario(u);

                        lblMensaje.ForeColor = Color.Green;
                        lblMensaje.Text = "El cambio de contraseña fue realizado exitosamente";
                    }
                    else
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "La nueva contraseña que usted digitó no corresponde a la contraseña confirmada";
                    }
                }
                else
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "La contraseña que usted digitó no corresponde a ninguno de los usuarios registrados";
                }
            }
        }

        private void CambiarContrasenna_Load(object sender, EventArgs e)
        {
            if (InicioSesion.ind2 == true)
            {
                txtNombreUsuario.Text = InicioSesion.nombreUsuario;
                txtNombreUsuario.ReadOnly = true;
            }

            //Los controles y los mensajes que se van a mostrar en los controles asignados
            hpAyuda.SetShowHelp(this.txtNombreUsuario, true);
            hpAyuda.SetHelpString(this.txtNombreUsuario, "Es el nombre de usuario con el que esta registrado");
            hpAyuda.SetShowHelp(this.txtContrasennaActual, true);
            hpAyuda.SetHelpString(this.txtContrasennaActual, "Es la contraseña que actualmente tiene registrado");
            hpAyuda.SetShowHelp(this.txtNuevaContrasenna, true);
            hpAyuda.SetHelpString(this.txtNuevaContrasenna, "Es la nueva contraseña con la que ingresará");
            hpAyuda.SetShowHelp(this.txtConfirmarContrasenna, true);
            hpAyuda.SetHelpString(this.txtConfirmarContrasenna, "Es la confirmación de la nueva contraseña");

            tltAyuda.AutoPopDelay = 5000;
            tltAyuda.InitialDelay = 500;
            tltAyuda.ReshowDelay = 500;
            tltAyuda.ShowAlways = true;
            tltAyuda.SetToolTip(this.txtNombreUsuario, "Es el nombre de usuario con el que esta registrado");
            tltAyuda.SetToolTip(this.txtContrasennaActual, "Es la contraseña que actualmente tiene registrado");
            tltAyuda.SetToolTip(this.txtNuevaContrasenna, "La contraseña debe contener letras y al menos un número");
            tltAyuda.SetToolTip(this.txtConfirmarContrasenna, "La contraseña debe ser la misma que digitó en el campo anterior");

            tltAyuda.SetToolTip(this.btnCambiarContrasenna, "Realiza el cambio de contraseña");
        }
    }
}
