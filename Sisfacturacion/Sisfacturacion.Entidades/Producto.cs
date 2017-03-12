using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Entidades
{
    public class Producto
    {
        public String idProducto { get; set; } 
	    public String nombre { get; set; }
	    public int cantidad { get; set; } 
	    public double precio { get; set; }
	    public String fechaIngreso { get; set; }
	    public String fechaVencimiento { get; set; } 
	    public int idCategoria { get; set; }
        public String nombreCategoria { get; set; }
        public String idProveedor { get; set; }
        public String nombreProveedor { get; set; }
	    public int estado { get; set; }
        public String nombreEstado { get; set; }
    }
}
