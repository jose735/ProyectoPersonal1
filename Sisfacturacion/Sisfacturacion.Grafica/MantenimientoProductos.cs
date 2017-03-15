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
    public partial class MantenimientoProductos : Form
    {
        ProductoLogica pl= new ProductoLogica();
        ProveedorLogica prl= new ProveedorLogica();
        CategoriaProductoLogica cpl= new CategoriaProductoLogica();
        Boolean ind = false;
        public MantenimientoProductos()
        {
            InitializeComponent();
        }

        public void refrescar()
        {
            //carga del combo de categoria
            cboCategoria.DataSource = cpl.ObtenerTodosCategoriaProducto();
            cboCategoria.DisplayMember = "descripcion";
            cboCategoria.ValueMember = "idCategoriaProducto";

            //carga del combo de proveedor
            cboProveedor.DataSource = prl.ObtenerTodosProveedor(1);
            cboProveedor.DisplayMember = "nombre";
            cboProveedor.ValueMember = "idProveedor";

            //carga del grid de producto
            dgvProducto.DataSource = pl.ObtenerTodosProducto(1);
        }

        public void cargarCombo()
        {
            //carga el combo de estado
            cboEstado.Items.Add("Seleccionar Estado");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.Items.Add("Todos");
        }

        public void limpiarCampos()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            nudCantidad.Value = 1;
            nudGanancia.Value = 1;
            cboCategoria.SelectedIndex = 0;
            cboProveedor.SelectedIndex = 0;
            lblMensaje.Text = "";
            dtpFechaVencimiento.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void MantenimientoProductos_Load(object sender, EventArgs e)
        {
            dgvProducto.AutoGenerateColumns = false;
            cargarCombo();
            refrescar();
            limpiarCampos();
        }

        private void MantenimientoProductos_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
            //verificar si hay campos nulos
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su registro";
            }
            else
            {
                //verifica que el producto exista y se lo informa al usuario
                if (pl.ObtenerProducto(txtCodigo.Text).Count > 0)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "Lo sentimos, este producto ya existe en el sistema, registre otro por favor";
                }
                else
                {
                    //crear la instancia de producto
                    Producto p = new Producto();
                    p.idProducto = txtCodigo.Text;
                    p.nombre = txtNombre.Text;
                    p.cantidad = Convert.ToInt32(nudCantidad.Value);
                    p.fechaIngreso = DateTime.Now.ToString("dd/MM/yyyy");
                    p.fechaVencimiento = dtpFechaVencimiento.Value.ToString("dd/MM/yyyy");
                    p.idCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                    p.idProveedor = cboProveedor.SelectedValue.ToString();
                    p.estado = 1;
                    try
                    {
                        double preVal = Convert.ToDouble(txtPrecio.Text);

                        p.precio = pl.precioRealProducto(Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(nudGanancia.Value));

                        //insertar el producto
                        pl.InsertarProducto(p);
                        refrescar();
                        lblMensaje.ForeColor = Color.Green;
                        lblMensaje.Text = "Producto registrado exitosamente";
                        ind = false;
                    }
                    catch (Exception)
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "El campo precio debe contener valores numéricos";
                        return;
                    }
                }
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            //verificar si hay campos nulos
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su modificación";
            }
            else
            {
                Producto p1 = (Producto)dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DataBoundItem;

                //crear la instancia de producto
                Producto p = new Producto();
                p.idProducto = p1.idProducto;
                p.nombre = txtNombre.Text;

                //si la cantidad de productos aumentó
                if (p1.cantidad < Convert.ToInt32(nudCantidad.Value))
                {
                    p.cantidad = Convert.ToInt32(nudCantidad.Value);
                    p.fechaIngreso = DateTime.Now.ToString("dd/MM/yyyy");

                }
                else
                {
                    //si la cantidad de productos va a disminuir
                    if (p1.cantidad > Convert.ToInt32(nudCantidad.Value))
                    {
                        lblMensaje.ForeColor = Color.Red;
                        lblMensaje.Text = "No es posible modificar la cantidad actual con otra cantidad menor";
                        return;
                    }
                    else
                    {
                        //si la cantidad de productos se mantiene igual
                        if (p1.cantidad == Convert.ToInt32(nudCantidad.Value))
                        {
                            p.cantidad = p1.cantidad;
                            p.fechaIngreso = p1.fechaIngreso;
                        }
                    }
                }

                p.fechaVencimiento = dtpFechaVencimiento.Value.ToString("dd/MM/yyyy");
                p.idCategoria = Convert.ToInt32(cboCategoria.SelectedValue);
                p.idProveedor = cboProveedor.SelectedValue.ToString();

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
                    p.estado = 2;
                }

                if (cboEstado.SelectedIndex == 3)
                {
                    p.estado = p1.estado;
                }

                try
                {
                    //verifica si el precio fue digitado con números
                    double preVal = Convert.ToDouble(txtPrecio.Text);

                    //verifica si el valor de ganancia sufrió un cambio y se vuelve a calcular el precio
                    if (ind == true)
                    {
                        p.precio = pl.precioRealProducto(Convert.ToDouble(txtPrecio.Text), Convert.ToDouble(nudGanancia.Value));
                    }
                    else
                    {
                        p.precio = p1.precio;
                    }

                    //modifica el producto
                    pl.ModificarProducto(p);
                    refrescar();
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Producto modificado exitosamente";
                    ind = false;
                }
                catch (Exception)
                {
                    lblMensaje.ForeColor = Color.Red;
                    lblMensaje.Text = "El campo precio debe contener valores numéricos";
                    return;
                }
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            //verificar si hay campos nulos
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtPrecio.Text == "")
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, complete los campos correspondientes para realizar su eliminación";
            }
            else
            {
                Producto p1 = (Producto)dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DataBoundItem;

                //crear la instancia de producto
                Producto p = new Producto();
                p.idProducto = p1.idProducto;
                p.nombre = txtNombre.Text;
                p.cantidad = p1.cantidad;
                p.fechaIngreso = p1.fechaIngreso;
                p.fechaVencimiento = p1.fechaVencimiento;
                p.precio = p1.precio;
                p.estado = 2;

                //obtiene la categoria seleccionada
                for (int i = 0; i < cboCategoria.Items.Count; i++)
                {
                    CategoriaProducto c = (CategoriaProducto)cboCategoria.Items[i];
                    if (c.descripcion == p1.nombreCategoria)
                    {
                        p.idCategoria= Convert.ToInt32(cboCategoria.SelectedValue);
                    }
                }

                //obtiene el proveedor seleccionado
                for (int i = 0; i < cboProveedor.Items.Count; i++)
                {
                    Proveedor p2 = (Proveedor)cboProveedor.Items[i];
                    if (p2.nombre == p1.nombreProveedor)
                    {
                        p.idProveedor= cboProveedor.SelectedValue.ToString();
                    }
                }

                //elimina el producto
                pl.ModificarProducto(p);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Producto eliminado exitosamente";
                ind = false;
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

            //selecciona los productos activos
            if (cboEstado.SelectedIndex == 1)
            {
                dgvProducto.DataSource = null;
                dgvProducto.DataSource = pl.ObtenerTodosProducto(1);
            }

            //selecciona los productos inactivos
            if (cboEstado.SelectedIndex == 2)
            {
                dgvProducto.DataSource = null;
                dgvProducto.DataSource = pl.ObtenerTodosProducto(2);
            }

            //selecciona todos los productos
            if (cboEstado.SelectedIndex == 3)
            {
                dgvProducto.DataSource = null;
                dgvProducto.DataSource = pl.ObtenerTodosProducto();
            }
        }

        private void dgvProducto_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si la fila ha sido seleccionada
            if (dgvProducto.SelectedRows.Count > 0)
            {
                //obtiene el objeto de la fila seleccionada
                Producto p1 = (Producto)dgvProducto.Rows[dgvProducto.SelectedRows[0].Index].DataBoundItem;

                txtCodigo.Text = p1.idProducto;
                txtNombre.Text = p1.nombre;
                txtPrecio.Text = p1.precio.ToString();
                nudCantidad.Value = p1.cantidad;
                nudGanancia.Value = 1;
                ind = false;
                String[] arreglo = p1.fechaVencimiento.Split('/');
                dtpFechaVencimiento.Value = new DateTime(int.Parse(arreglo[2]), int.Parse(arreglo[1]), int.Parse(arreglo[0]));

                //obtiene la categoria seleccionada
                for (int i = 0; i < cboCategoria.Items.Count; i++)
                {
                    CategoriaProducto c = (CategoriaProducto)cboCategoria.Items[i];
                    if (c.descripcion == p1.nombreCategoria)
                    {
                        cboCategoria.SelectedIndex = i;
                    }
                }

                //obtiene el proveedor seleccionado
                for (int i = 0; i < cboProveedor.Items.Count; i++)
                {
                    Proveedor p = (Proveedor)cboProveedor.Items[i];
                    if (p.nombre == p1.nombreProveedor)
                    {
                        cboProveedor.SelectedIndex = i;
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void nudGanancia_ValueChanged(object sender, EventArgs e)
        {
            ind = true;
        }
    }
}