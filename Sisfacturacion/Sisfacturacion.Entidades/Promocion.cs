using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Entidades
{
    public class Promocion
    {
        public int idPromocion { get; set; }
        public String idProducto { get; set; }
        public String nombreProducto { get; set; }
        public double precio { get; set; }
        public int cantidad { get; set; }
        public double porcentajeDescuento { get; set; }
        public int estado { get; set; }
        public String nombreEstado { get; set; }
    }
}
