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
    public partial class MostrarFactura : Form
    {
        public MostrarFactura()
        {
            InitializeComponent();
        }

        private void MostrarFactura_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DB_SisFacturacionDataSet.PA_Seleccionar_Por_Id_Enc_Factura' Puede moverla o quitarla según sea necesario.
            this.PA_Seleccionar_Por_Id_Enc_FacturaTableAdapter.Fill(this.DB_SisFacturacionDataSet.PA_Seleccionar_Por_Id_Enc_Factura, Facturacion.idFactura);
            // TODO: esta línea de código carga datos en la tabla 'DB_SisFacturacionDataSet1.PA_Seleccionar_Por_Id_Det_Factura' Puede moverla o quitarla según sea necesario.
            this.PA_Seleccionar_Por_Id_Det_FacturaTableAdapter.Fill(this.DB_SisFacturacionDataSet1.PA_Seleccionar_Por_Id_Det_Factura, Facturacion.idFactura);

            this.reportViewer1.RefreshReport();
        }
    }
}
