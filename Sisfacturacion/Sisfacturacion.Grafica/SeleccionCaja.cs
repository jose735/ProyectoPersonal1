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
    public partial class SeleccionCaja : Form
    {
        CajaLogica cl = new CajaLogica();
        UsuarioLogica ul = new UsuarioLogica();
        public static String nombreCaja = "";
        public static int codCaja = 0;
        public SeleccionCaja()
        {
            InitializeComponent();
        }

        public void refrescar()
        {
            //trae todas las cajas debido a que va a accesar un administrador o un supervisor
            if (InicioSesion.AdminSuperv == true)
            {
                //carga de combo de cajas activas
                cboCajas.DataSource = cl.ObtenerTodosCajas(1);
                cboCajas.DisplayMember = "descripcion";
                cboCajas.ValueMember = "idCaja";
            }
            else
            {
                //trae las cajas asignadas al usuario que es un cajero
                //carga de combo de cajas activas
                cboCajas.DataSource = ul.ObtenerCajaPorUsuario2(InicioSesion.nombreUsuario);
                cboCajas.DisplayMember = "descripcion";
                cboCajas.ValueMember = "idCaja";
            }
        }

        private void SeleccionCaja_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            InicioSesion.codigoCaja = Convert.ToInt32(cboCajas.SelectedValue);
            Caja c = (Caja) cboCajas.SelectedItem;
            InicioSesion.nombreDeCaja = c.descripcion;
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }

        private void SeleccionCaja_FormClosed(object sender, FormClosedEventArgs e)
        {
            //crea una instancia del menu principal, se muestra el menu principal y se cierra la ventana actual
            Principal p = new Principal();
            p.Show();
            this.Hide();
        }
    }
}
