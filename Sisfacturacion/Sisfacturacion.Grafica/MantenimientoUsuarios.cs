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
            tiempoCarga.Start();
            tiempoCarga.Interval = uL.ObtenerTodosUsuarios(1).Count * 5;

            //Los controles y los mensajes que se van a mostrar en los controles asignados
            hpAyuda.SetShowHelp(this.txtNombreUsuario, true);
            hpAyuda.SetHelpString(this.txtNombreUsuario, "Es el alias con el que se ingresará al sistema");
            hpAyuda.SetShowHelp(this.cboTipoUsuario, true);
            hpAyuda.SetHelpString(this.cboTipoUsuario, "Selecciona el tipo de usuario que se maneja en el sistema");
            hpAyuda.SetShowHelp(this.cboEstado, true);
            hpAyuda.SetHelpString(this.cboEstado, "Selecciona el estado de los usuarios que se va a mostrar");

            tltAyuda.AutoPopDelay = 5000;
            tltAyuda.InitialDelay = 500;
            tltAyuda.ReshowDelay = 500;
            tltAyuda.ShowAlways = true;
            tltAyuda.SetToolTip(this.txtNombreUsuario, "Nombre con el que se ingresara en el sistema");
            tltAyuda.SetToolTip(this.cboTipoUsuario, "Selecciona el tipo de usuario que se maneja en el sistema");
            tltAyuda.SetToolTip(this.cboEstado, "Selecciona el estado de los usuarios que se va a mostrar");

            tltAyuda.SetToolTip(this.btnEliminarUsuario, "Inactiva un usuario");
            tltAyuda.SetToolTip(this.btnInsertarUsuario, "Registra un nuevo usuario");
            tltAyuda.SetToolTip(this.btnLimpiarCampos, "Deja los campos vacios para nuevos registros");
            tltAyuda.SetToolTip(this.btnMenuPrincipal, "Regresa al menu principal");
            tltAyuda.SetToolTip(this.btnModificarEstado, "Activa un usuario");
            tltAyuda.SetToolTip(this.btnMostrarUsuarios, "Muestra usuarios dependiendo del estadio");

            //alterna colores en la filas del datagridview
            dgvUsuarios.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvUsuarios.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            //no genera columnas de manera automatica
            dgvUsuarios.AutoGenerateColumns = false;
            btnModificarEstado.Enabled = false;
            //refrescar();
            cargarCombo();
            limpiarCampos();
        }

        public void refrescar()
        {
            //Carga el combo de tipos de usuario
            cboTipoUsuario.DataSource = tipoU.ObtenerTodosUsuarios();
            cboTipoUsuario.DisplayMember = "descripcion";
            cboTipoUsuario.ValueMember = "idTipoUsuario";

            //Carga el datagridview de usuarios
            dgvUsuarios.DataSource = uL.ObtenerTodosUsuarios(1);
        }

        public void cargarCombo()
        {
            //Carga el combo de tipos de usuario
            cboTipoUsuario.DataSource = tipoU.ObtenerTodosUsuarios();
            cboTipoUsuario.DisplayMember = "descripcion";
            cboTipoUsuario.ValueMember = "idTipoUsuario";

            //carga de combo de estado
            cboEstado.Items.Add("Seleccionar Estado");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.Items.Add("Todos");
        }


        //limpia el valor de todos los campos
        public void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtContrasenna.Text = "";
            txtNombreCompleto.Text = "";
            cboTipoUsuario.SelectedIndex = 0;
            lblMensaje.Text = "";
            cboEstado.SelectedIndex = 0;
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

                //obtiene el estado seleccionado
                for (int i = 0; i < cboEstado.Items.Count; i++)
                {
                    String estado = cboEstado.Items[i].ToString();
                    if (u.nombreEstado == estado)
                    {
                        cboEstado.SelectedIndex = i;
                    }
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
                    u.estado = 1;

                    if (InicioSesion.tipoDeUsuario == 2 && u.idTipoUsuario == 3)
                    {
                        //inserta al usuario
                        uL.InsertarUsuario(u);
                        lblMensaje.ForeColor = Color.Green;
                        lblMensaje.Text = "Usuario registrado exitosamente";
                        refrescar();
                    }
                    else
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "Usuario no autorizado a registrar administradores o suspervisores, unicamente cajeros";
                    }
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
                if (uL.ObtenerCajaPorUsuario(txtNombreUsuario.Text) > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Lo sentimos, no se puede eliminar a este usuario debido a que tiene una caja asignada";
                }
                else
                {
                    if (txtNombreUsuario.Text == InicioSesion.nombreUsuario)
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "No se puede eliminar este usuario debido a que esta activo en este momento";
                    }
                    else
                    {
                        Usuario u1 = (Usuario)dgvUsuarios.Rows[dgvUsuarios.SelectedRows[0].Index].DataBoundItem;
                        Usuario u = new Usuario();
                        u.nombreUsuario = txtNombreUsuario.Text;
                        u.estado = 2;
                        if (InicioSesion.tipoDeUsuario == 2 && u1.nombreTipoUsuario == "Cajero")
                        {
                            uL.ModificarUsuario2(u);
                            lblMensaje.ForeColor = Color.Green;
                            lblMensaje.Text = "Usuario eliminado exitosamente";
                            refrescar();
                        }
                        else
                        {
                            lblMensaje.ForeColor = Color.Red;
                            lblMensaje.Text = "Usuario no autorizado a eliminar administradores o suspervisores, unicamente cajeros";
                        }
                    }
                }
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

        private void btnModificarEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarUsuarios_Click(object sender, EventArgs e)
        {
            if (cboEstado.SelectedIndex == 0)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, seleccione un estado";
            }

            if (cboEstado.SelectedIndex == 1)
            {
                btnModificarEstado.Enabled = false;
                dgvUsuarios.DataSource= null;
                dgvUsuarios.DataSource = uL.ObtenerTodosUsuarios(1);
            }

            if (cboEstado.SelectedIndex == 2)
            {
                btnModificarEstado.Enabled = true;
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = uL.ObtenerTodosUsuarios(2);
            }

            if (cboEstado.SelectedIndex == 3)
            {
                btnModificarEstado.Enabled = true;
                dgvUsuarios.DataSource = null;
                dgvUsuarios.DataSource = uL.ObtenerTodosUsuarios();
            }
        }

        private void btnModificarEstado_Click_1(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
            u.nombreUsuario = txtNombreUsuario.Text;
            u.estado = 1;
            uL.ModificarUsuario2(u);
            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Text = "Usuario activado exitosamente";
            btnModificarEstado.Enabled = false;
            refrescar();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void tiempoCarga_Tick(object sender, EventArgs e)
        {
            pbCarga.Increment(1);
            dgvUsuarios.Enabled = false;
            lblPorcentaje.Text = pbCarga.Value.ToString() + "%   Cargando datos de usuarios, espere por favor";
            if (pbCarga.Value == 100)
            {
                dgvUsuarios.DataSource = uL.ObtenerTodosUsuarios(1);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Carga de usuarios realizada exitosamente";
                pbCarga.Visible = false;
                dgvUsuarios.Enabled = true;
                tiempoCarga.Stop();
                lblPorcentaje.Text = "";

            }
        }
    }
}
