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
        PromocionLogica proml = new PromocionLogica();
        List<Producto> ListaDetalle = new List<Producto>();
        Producto productoDetallar = new Producto();
        double subtotal = 0;
        double total = 0;
        int nuevoInventario = 0;
        double precioDelProducto = 0;

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

        public void LimpiarCamposProducto()
        {
            txtCodigoProducto.Text = "";
            txtNombreProducto.Text = "";
            nudCantidad.Value = 1;
        }

        public void disminuirInventario()
        {
            //Disminuir el inventario del producto a facturar
            Producto p = new Producto();
            p.nombre= productoDetallar.nombre;
            p.idProducto = productoDetallar.idProducto;
            p.idCategoria = productoDetallar.idCategoria;
            p.idProveedor = productoDetallar.idProveedor;
            p.fechaIngreso = productoDetallar.fechaIngreso;
            p.fechaVencimiento = productoDetallar.fechaVencimiento;
            p.estado = productoDetallar.estado;
            p.precio = precioDelProducto;
            p.cantidad = nuevoInventario;
            prodl.ModificarProducto(p);
            nuevoInventario = 0;
            precioDelProducto = 0;
        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            dgvProductosDetalle.AutoGenerateColumns = false;
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
                        productoDetallar = p;
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
                        productoDetallar = p;
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

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            //verifica si la busqueda no se ha efectuado
            if (txtCodigoProducto.Text == "" || txtNombreProducto.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "El código y el nombre del producto deben estar digitados, por favor realice la busqueda del producto";
            }
            else
            {
                //verifica si hay suficiente producto en el inventario
                if (productoDetallar.cantidad < Convert.ToInt32(nudCantidad.Value))
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "No se encuentra la cantidad que desea de este producto en el inventario";
                }
                else
                {
                    lblMensaje.Text = "";
                    subtotal = 0;

                    //resta del inventario con la cantidad deseada
                    nuevoInventario = productoDetallar.cantidad - Convert.ToInt32(nudCantidad.Value);

                    //mantener el precio actual del producto
                    precioDelProducto = productoDetallar.precio;

                    //verificar si el producto tiene promocion y hacer el descuento
                    for (int i = 0; i < proml.ObtenerTodosPromocion(1).Count; i++)
                    {
                        if (proml.ObtenerTodosPromocion(1).ElementAt(i).idProducto == productoDetallar.idProducto)
                        {
                            productoDetallar.precio = productoDetallar.precio - (productoDetallar.precio * (proml.ObtenerTodosPromocion(1).ElementAt(i).porcentajeDescuento / 100));
                        }
                    }

                    //facturacion del producto
                    productoDetallar.cantidad = Convert.ToInt32(nudCantidad.Value);
                    ListaDetalle.Add(productoDetallar);
                    dgvProductosDetalle.DataSource = null;
                    dgvProductosDetalle.DataSource = ListaDetalle;


                    //recorre la lista de detalle para calcular el subtotal y el total
                    for (int i = 0; i < ListaDetalle.Count; i++)
                    {
                        subtotal += ListaDetalle.ElementAt(i).precio * ListaDetalle.ElementAt(i).cantidad;
                    }

                    //calculo de impuesto y total de todos los productos
                    double impuesto = subtotal * 0.13;
                    total = subtotal + impuesto;

                    txtSubtotal.Text = subtotal.ToString("# ###.00");
                    txtTotal.Text = total.ToString("# ###.00");
                    txtImpuesto.Text = impuesto.ToString("# ###.00");

                    disminuirInventario();

                    LimpiarCamposProducto();
                }
            }
        }

        private void btnFinalizarFactura_Click(object sender, EventArgs e)
        {

        }
    }
}
