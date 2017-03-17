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
    public partial class MantenimientoPromociones : Form
    {
        ProductoLogica prodl = new ProductoLogica();
        PromocionLogica proml = new PromocionLogica();

        public MantenimientoPromociones()
        {
            InitializeComponent();
        }

        public void refrescar()
        {
            //carga de grid de productos activos
            dgvProductos.DataSource = prodl.ObtenerTodosProducto(1);

            //carga del grid de promociones activas
            dgvPromociones.DataSource = proml.ObtenerTodosPromocion(1);
        }

        public void LimpiarCampos()
        {
            lblMensaje.Text = "";
            nudPorcentaje.Value = 0;
            cboEstado.SelectedIndex = 0;
        }

        public void cargarCombo()
        {
            //carga de combo de estado
            cboEstado.Items.Add("Seleccionar Estado");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.Items.Add("Todos");
        }

        private void MantenimientoPromociones_Load(object sender, EventArgs e)
        {
            dgvProductos.AutoGenerateColumns = false;
            dgvPromociones.AutoGenerateColumns = false;
            cargarCombo();
            refrescar();
            LimpiarCampos();
        }

        private void MantenimientoPromociones_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void btnMostrarEstado_Click(object sender, EventArgs e)
        {
            //verifica que se haya seleccionado una opcion
            if (cboEstado.SelectedIndex == 0)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Por favor, seleccione un estado";
            }

            //selecciona los promociones activas
            if (cboEstado.SelectedIndex == 1)
            {
                dgvPromociones.DataSource = null;
                dgvPromociones.DataSource = proml.ObtenerTodosPromocion(1);
            }

            //selecciona los promociones inactivas
            if (cboEstado.SelectedIndex == 2)
            {
                dgvPromociones.DataSource = null;
                dgvPromociones.DataSource = proml.ObtenerTodosPromocion(2);
            }

            //selecciona todas los promociones
            if (cboEstado.SelectedIndex == 3)
            {
                dgvPromociones.DataSource = null;
                dgvPromociones.DataSource = proml.ObtenerTodosPromocion();
            }
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void btnInsertarPromocion_Click(object sender, EventArgs e)
        {
            //es la instancia del producto seleccionado
            Producto p1 = (Producto)dgvProductos.Rows[dgvProductos.SelectedRows[0].Index].DataBoundItem;

            //valida que lla promoción ya exista
            if (proml.ObtenerPromocion(p1.idProducto, 1).Count > 0)
            {
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Lo sentimos, esta promocion ya existe en el sistema, registre otro por favor";
            }
            else
            {
                //Creación de la instancia del producto
                Promocion pr = new Promocion();
                pr.idProducto = p1.idProducto;
                pr.porcentajeDescuento = Convert.ToDouble(nudPorcentaje.Value);
                pr.estado = 1;

                //insertar la promoción
                proml.InsertarProveedor(pr);
                refrescar();
                lblMensaje.ForeColor = Color.Green;
                lblMensaje.Text = "Promoción registrada exitosamente";
            }
        }

        private void btnModificarPromocion_Click(object sender, EventArgs e)
        {
            Promocion p1 = (Promocion)dgvPromociones.Rows[dgvPromociones.SelectedRows[0].Index].DataBoundItem;

            //crear la instancia de promoción
            Promocion p = new Promocion();
            p.idPromocion = p1.idPromocion;
            p.porcentajeDescuento = Convert.ToDouble(nudPorcentaje.Value);

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

            //modifica la promocion
            proml.ModificarPromocion(p);
            refrescar();
            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Text = "Promoción modificada exitosamente";
        }

        private void btnEliminarPromocion_Click(object sender, EventArgs e)
        {
            Promocion p1 = (Promocion)dgvPromociones.Rows[dgvPromociones.SelectedRows[0].Index].DataBoundItem;

            //crear la instancia de promoción
            Promocion p = proml.ObtenerPromocion(p1.idProducto, 1).ElementAt(0);
            p.idPromocion = p1.idPromocion;
            p.porcentajeDescuento = p1.porcentajeDescuento;
            p.estado = 2;

            //eliminar la promoción
            proml.ModificarPromocion(p);
            refrescar();
            lblMensaje.ForeColor = Color.Green;
            lblMensaje.Text = "Promoción eliminado exitosamente";
        }

        private void dgvPromociones_SelectionChanged(object sender, EventArgs e)
        {
            //verifica si la fila ha sido seleccionada
            if (dgvPromociones.SelectedRows.Count > 0)
            {
                //obtiene el objeto de la fila seleccionada
                Promocion p1 = (Promocion)dgvPromociones.Rows[dgvPromociones.SelectedRows[0].Index].DataBoundItem;

                nudPorcentaje.Value = Convert.ToDecimal(p1.porcentajeDescuento);

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
    }
}
