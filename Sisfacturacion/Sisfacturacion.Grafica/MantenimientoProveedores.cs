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
            cboCiudad.DataSource = cl.ObtenerTodosCiudad(1);
            cboCiudad.DisplayMember = "descripcion";
            cboCiudad.ValueMember = "idCiudad";
        }

        public void limpiarCampos()
        {

        }

        public void cargarCombo()
        {
            cboEstado.Items.Add("Seleccionar Estado");
            cboEstado.Items.Add("Activo");
            cboEstado.Items.Add("Inactivo");
            cboEstado.Items.Add("Todos");
        }

        private void MantenimientoProveedores_Load(object sender, EventArgs e)
        {
            dgvProveedores.AutoGenerateColumns = false;
            cargarCombo();
            refrescar();
            limpiarCampos();
        }

        private void MantenimientoProveedores_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {

        }

        private void btnMostrarEstado_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
