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
    public partial class Facturacion : Form
    {
        ProductoLogica prodl = new ProductoLogica();
        TipoPagoLogica tpl = new TipoPagoLogica();
        ClienteLogica cl = new ClienteLogica();

        public Facturacion()
        {
            InitializeComponent();
        }

        public void cargarCombo()
        {
            cboTipoPago.DataSource = tpl.ObtenerTodosTipoPago();
            cboTipoPago.DisplayMember = "descripcion";
            cboTipoPago.ValueMember = "idTipoPago";
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            txtNombreCaja.Enabled = false;
            txtNombreCaja.Text = SeleccionCaja.nombreCaja;
            txtSubtotal.Enabled = false;
            txtImpuesto.Enabled = false;
            txtTotal.Enabled = false;

            btnRegistrarCliente.Visible = false;

            cargarCombo();
        }

        private void Facturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            //verificar si hay campos nulos
            if (txtIdentificacion.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Debe llenar el campo de número de identificación para realizar la busqueda";
            }
            else
            {
                //verificar si se encuentra un cliente con ese número de identificación
                if (cl.ObtenerCliente(txtIdentificacion.Text).Count == 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "El cliente que busca no existe en el sistema, llene los demás campos para su registro";
                    btnRegistrarCliente.Visible = true;
                }
                else
                {
                    //creación de instancia de cliente
                    Cliente c = cl.ObtenerCliente(txtIdentificacion.Text).ElementAt(0);
                    txtNombreCliente.Text = c.nombre;
                    txtTelefonoCliente.Text = c.telefono;
                    txtDireccionCliente.Text = c.direccion;

                    txtIdentificacion.Enabled = false;
                    txtNombreCliente.Enabled = false;
                    txtTelefonoCliente.Enabled = false;
                    txtDireccionCliente.Enabled = false;
                }
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            //verificar que no haya campos nulos
            if (txtCodigoProducto.Text == "" && txtNombreProducto.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Debe llenar los campos correspondientes para realizar la busqueda";
            }
            else
            {
                //buscar producto por código
                if (txtCodigoProducto.Text != "")
                {
                    //verificar si existe un producto con el código registrado
                    if (prodl.ObtenerProducto(txtCodigoProducto.Text).Count == 0)
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "El producto que busca no existe en el sistema";
                    }
                    else
                    {
                        Producto p = prodl.ObtenerProducto(txtCodigoProducto.Text).ElementAt(0);
                        txtNombreProducto.Text = p.nombre;
                    }
                }

                //buscar producto por nombre del producto
                if (txtNombreProducto.Text != "")
                {
                    //verificar si existe un producto con el nombre registrado
                    if (prodl.ObtenerProducto2(txtNombreProducto.Text).Count == 0)
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "El producto que busca no existe en el sistema";
                    }
                    else
                    {
                        Producto p = prodl.ObtenerProducto2(txtNombreProducto.Text).ElementAt(0);
                        txtCodigoProducto.Text = p.idProducto;
                    }
                }
            }
        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            //verificar si hay campos nulos
            if (txtNombreCliente.Text == "" || txtTelefonoCliente.Text == "" || txtDireccionCliente.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Debe llenar los campos correspondientes para realizar su registro";
            }
            else
            {
                //crear instancia de cliente
                Cliente c = new Cliente();
                c.idCliente = txtIdentificacion.Text;
                c.nombre = txtNombreCliente.Text;
                c.telefono = txtTelefonoCliente.Text;
                c.direccion = txtDireccionCliente.Text;

                //insertar cliente
                cl.InsertarCliente(c);
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Cliente registrado exitosamente, continue con su facturación";

                txtIdentificacion.Enabled = false;
                txtNombreCliente.Enabled = false;
                txtTelefonoCliente.Enabled = false;
                txtDireccionCliente.Enabled = false;
            }
        }
    }
}
