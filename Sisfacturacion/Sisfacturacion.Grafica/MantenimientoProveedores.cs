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
    public partial class MantenimientoProveedores : Form
    {
        CiudadLogica cl = new CiudadLogica();
        ProveedorLogica pL = new ProveedorLogica();
        public MantenimientoProveedores()
        {
            InitializeComponent();
        }

        public void refrescar()
        {
            //carga del grid de proveedores
            dgvProveedores.DataSource = pL.ObtenerTodosProveedor(1);

            //carga del combo de ciudad
            cboCiudad.DataSource = cl.ObtenerTodosCiudad(1);
            cboCiudad.DisplayMember = "descripcion";
            cboCiudad.ValueMember = "idCiudad";
        }

        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtNombreRepartidor.Text = "";
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            cboCiudad.SelectedIndex = 0;
            cboEstado.SelectedIndex = 0;
        }

        public void cargarCombo()
        {
            //carga del combo de ciudad
            cboCiudad.DataSource = cl.ObtenerTodosCiudad(1);
            cboCiudad.DisplayMember = "descripcion";
            cboCiudad.ValueMember = "idCiudad";

            cboEstado.Items.Add("Seleccionar Estado");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.Items.Add("Todos");
        }

        private void MantenimientoProveedores_Load(object sender, EventArgs e)
        {
            tiempoCarga.Start();
            tiempoCarga.Interval = pL.ObtenerTodosProveedor(1).Count * 5;

            //Los controles y los mensajes que se van a mostrar en los controles asignados
            hpAyuda.SetShowHelp(this.txtCodigo, true);
            hpAyuda.SetHelpString(this.txtCodigo, "Es el código asignado al proveedor");
            hpAyuda.SetShowHelp(this.txtNombre, true);
            hpAyuda.SetHelpString(this.txtNombre, "Es el nombre registrado del proveedor");
            hpAyuda.SetShowHelp(this.txtNombreRepartidor, true);
            hpAyuda.SetHelpString(this.txtNombreRepartidor, "Es el nombre del repartidor encargado de llevar el producto");
            hpAyuda.SetShowHelp(this.txtDireccion, true);
            hpAyuda.SetHelpString(this.txtDireccion, "Es la dirección exacta de la ubicación del proveedor");
            hpAyuda.SetShowHelp(this.txtTelefono, true);
            hpAyuda.SetHelpString(this.txtTelefono, "Es el número de teléfono de contacto con el proveedor");
            hpAyuda.SetShowHelp(this.cboCiudad, true);
            hpAyuda.SetHelpString(this.cboCiudad, "Selecciona la ciudad donde esta localizado el proveedor");
            hpAyuda.SetShowHelp(this.cboEstado, true);
            hpAyuda.SetHelpString(this.cboEstado, "Selecciona el estado de los proveedores que se va a mostrar");

            tltAyuda.AutoPopDelay = 5000;
            tltAyuda.InitialDelay = 500;
            tltAyuda.ReshowDelay = 500;
            tltAyuda.ShowAlways = true;
            tltAyuda.SetToolTip(this.txtCodigo, "Es el código asignado al proveedor");
            tltAyuda.SetToolTip(this.txtNombre, "Es el nombre registrado del proveedor");
            tltAyuda.SetToolTip(this.txtNombreRepartidor, "Es el nombre del repartidor encargado de llevar el producto");
            tltAyuda.SetToolTip(this.txtDireccion, "Es la dirección exacta de la ubicación del proveedor");
            tltAyuda.SetToolTip(this.txtTelefono, "Es el número de teléfono de contacto con el proveedor");
            tltAyuda.SetToolTip(this.cboCiudad, "Selecciona la ciudad donde esta localizado el proveedor");
            tltAyuda.SetToolTip(this.cboEstado, "Selecciona el estado de los proveedores que se va a mostrar");

            tltAyuda.SetToolTip(this.btnEliminarProveedor, "Elimina un proveedor");
            tltAyuda.SetToolTip(this.btnInsertarProveedor, "Registra un nuevo proveedor");
            tltAyuda.SetToolTip(this.btnLimpiarCampos, "Deja los campos vacios para nuevos registros");
            tltAyuda.SetToolTip(this.btnMenuPrincipal, "Regresa al menu principal");
            tltAyuda.SetToolTip(this.btnModificarProveedor, "Edita los registros de un proveedor");
            tltAyuda.SetToolTip(this.btnMostrarEstado, "Muestra proveedores dependiendo del estado");

            //alterna colores en la filas del datagridview
            dgvProveedores.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgvProveedores.AlternatingRowsDefaultCellStyle.BackColor = Color.White;

            //no genera columnas de manera automatica
            dgvProveedores.AutoGenerateColumns = false;
            cargarCombo();
            //refrescar();
            limpiarCampos();
        }

        private void MantenimientoProveedores_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {
            //validar si los campos estan nulos
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtNombreRepartidor.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su registro";
            }
            else
            {
                //verifica que el proveedor exista y se lo informa al usuario
                if (pL.ObtenerProveedor(txtCodigo.Text).Count > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Lo sentimos, este proveedor ya existe en el sistema, registre otro por favor";
                }
                else
                {
                    //creacion de la instancia de proveedor
                    Proveedor p = new Proveedor();
                    p.idProveedor = txtCodigo.Text;
                    p.nombre = txtNombre.Text;
                    p.nombreRepartidor = txtNombreRepartidor.Text;
                    p.direccionLocal = txtDireccion.Text;
                    p.telefono = txtTelefono.Text;
                    p.idCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
                    p.estado = 1;

                    //insertar el proveedor
                    pL.InsertarProveedor(p);
                    refrescar();
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Proveedor registrado exitosamente";
                }
            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            //validar si los campos estan nulos
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtNombreRepartidor.Text == "" || txtTelefono.Text == "" || txtDireccion.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su modificación";
            }
            else
            {
                Proveedor p1 = (Proveedor) dgvProveedores.Rows[dgvProveedores.SelectedRows[0].Index].DataBoundItem;

                //creacion de la instancia de proveedor
                Proveedor p = new Proveedor();
                p.idProveedor = txtCodigo.Text;
                p.nombre = txtNombre.Text;
                p.nombreRepartidor = txtNombreRepartidor.Text;
                p.direccionLocal = txtDireccion.Text;
                p.telefono = txtTelefono.Text;
                p.idCiudad = Convert.ToInt32(cboCiudad.SelectedValue);

                if (cboEstado.SelectedIndex == 0)
                {
                    p.estado = p1.estado;
                }

                if (cboEstado.SelectedIndex == 1)
                {
                    p.estado = 1;
                }

                if (cboEstado.SelectedIndex == 2)
                {
                    //verifica que algún producto este ligado al proveedor que se va a eliminar
                    if (pL.ObtenerProductoPorProveedor(p1.idProveedor) > 0)
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "Lo sentimos, no se puede cambiar el estado de este proveedor por estar relacionado con varios productos";
                        return;
                    }
                    else
                    {
                        p.estado = 2;
                    }
                }

                if (cboEstado.SelectedIndex == 3)
                {
                    p.estado = p1.estado;
                }

                //modifica el proveedor
                pL.ModificarProveedor(p);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Proveedor modificado exitosamente";
            }
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            //validar si los campos estan nulos
            if (txtCodigo.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su eliminación";
            }
            else
            {
                Proveedor p1 = (Proveedor)dgvProveedores.Rows[dgvProveedores.SelectedRows[0].Index].DataBoundItem;

                //verifica que algún producto este ligado al proveedor que se va a eliminar
                if (pL.ObtenerProductoPorProveedor(p1.idProveedor) > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Lo sentimos, no se puede eliminar este proveedor por estar relacionado con varios productos";
                }
                else
                {
                    //creacion de la instancia de proveedor
                    Proveedor p = new Proveedor();
                    p.idProveedor = p1.idProveedor;
                    p.nombre = p1.nombre;
                    p.nombreRepartidor = p1.nombreRepartidor;
                    p.direccionLocal = p1.direccionLocal;
                    p.telefono = p1.telefono;
                    p.nombreEstado = p1.nombreEstado;
                    p.estado = 2;

                    //obtiene el usuario seleccionado
                    for (int i = 0; i < cboCiudad.Items.Count; i++)
                    {
                        Ciudad c = (Ciudad)cboCiudad.Items[i];
                        if (c.descripcion == p1.nombreCiudad)
                        {
                            p.idCiudad = Convert.ToInt32(cboCiudad.SelectedValue);
                        }
                    }

                    //elimina el proveedor
                    pL.ModificarProveedor(p);
                    refrescar();
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Proveedor eliminado exitosamente";
                }
            }
        }

        private void btnMostrarEstado_Click(object sender, EventArgs e)
        {
            //verifica que se haya seleccionado una opcion
            if (cboEstado.SelectedIndex == 0)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, seleccione un estado";
            }

            //selecciona las ciudades activas
            if (cboEstado.SelectedIndex == 1)
            {
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = pL.ObtenerTodosProveedor(1);
            }

            //selecciona las ciudades inactivas
            if (cboEstado.SelectedIndex == 2)
            {
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = pL.ObtenerTodosProveedor(2);
            }

            //selecciona todas las ciudades
            if (cboEstado.SelectedIndex == 3)
            {
                dgvProveedores.DataSource = null;
                dgvProveedores.DataSource = pL.ObtenerTodosProveedor();
            }
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si la fila ha sido seleccionada
            if (dgvProveedores.SelectedRows.Count > 0)
            {
                //obtiene el objeto de la fila seleccionada
                Proveedor p1 = (Proveedor)dgvProveedores.Rows[dgvProveedores.SelectedRows[0].Index].DataBoundItem;

                txtCodigo.Text = p1.idProveedor;
                txtNombre.Text = p1.nombre;
                txtNombreRepartidor.Text = p1.nombreRepartidor;
                txtDireccion.Text = p1.direccionLocal;
                txtTelefono.Text = p1.telefono;

                //obtiene la ciudad seleccionada
                for (int i = 0; i < cboCiudad.Items.Count; i++)
                {
                    Ciudad c = (Ciudad)cboCiudad.Items[i];
                    if (c.descripcion == p1.nombreCiudad)
                    {
                        cboCiudad.SelectedIndex = i;
                    }
                }

                //obtiene el estado seleccionado
                for (int i = 0; i < cboEstado.Items.Count; i++)
                {
                    String estado = cboEstado.Items[i].ToString();
                    if (p1.nombreEstado == estado)
                    {
                        cboEstado.SelectedIndex = i;
                    }
                }
            }
        }

        private void tiempoCarga_Tick(object sender, EventArgs e)
        {
            pbCarga.Increment(1);
            dgvProveedores.Enabled = false;
            lblPorcentaje.Text = pbCarga.Value.ToString() + "%   Cargando datos de proveedores, espere por favor";
            if (pbCarga.Value == 100)
            {
                dgvProveedores.DataSource = pL.ObtenerTodosProveedor(1);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Carga de proveedores realizada exitosamente";
                pbCarga.Visible = false;
                dgvProveedores.Enabled = true;
                tiempoCarga.Stop();
                lblPorcentaje.Text = "";
            }
        }
    }
}
