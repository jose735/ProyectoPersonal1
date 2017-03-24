using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Entidades
{
    public class Factura
    {
        public String nombreLocal { get; set; }
        public int idEncFactura { get; set; }
        public int idDetFactura { get; set; }
        public String idProducto { get; set; }
        public String nombreProducto { get; set; }
        public int cantidadProducto { get; set; }
        public double precioProducto { get; set; }
        public String idCliente { get; set; }
        public String nombreCliente { get; set; }
        public int idCaja { get; set; }
        public String nombreCaja { get; set; }
        public int idTipoPago { get; set; }
        public String nombreTipoPago { get; set; }
        public int idUsuario { get; set; }
        public String nombreUsuario { get; set; }
        public double subtotal { get; set; }
        public double impuesto { get; set; }
        public double total { get; set; }
        public String fechaCreacion { get; set; }
        public double montoAPagar { get; set; }
        public double cambio { get; set; }
    }
}
