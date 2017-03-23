using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class FacturaLogica
    {
        public void InsertarEncFactura(Factura encabezado)
        {
            FacturaDatos datos = new FacturaDatos();
            datos.InsertarEncabezado(encabezado);
        }

        public void InsertarDetFactura(Factura detalle)
        {
            FacturaDatos datos = new FacturaDatos();
            datos.InsertarDetalle(detalle);
        }

        public void EliminarEncFactura(int idEncFactura)
        {
            FacturaDatos datos = new FacturaDatos();
            datos.EliminarEncabezado(idEncFactura);
        }

        public void EliminarDetFactura(int idEncFactura)
        {
            FacturaDatos datos = new FacturaDatos();
            datos.EliminarDetalle(idEncFactura);
        }

        public int ObtenerUltimaFactura()
        {
            FacturaDatos datos = new FacturaDatos();
            return datos.SeleccionarUltimaFactura();
        }
    }
}
