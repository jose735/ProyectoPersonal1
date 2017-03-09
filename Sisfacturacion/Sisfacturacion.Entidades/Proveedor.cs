using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Entidades
{
    public class Proveedor
    {
        public String idProveedor { get; set; }
        public String nombre { get; set; }
        public String nombreRepartidor { get; set; }
        public int idCiudad { get; set; }
        public String nombreCiudad { get; set; }
        public String direccionLocal { get; set; }
        public String telefono { get; set; }
        public int estado { get; set; }
        public String nombreEstado { get; set; }
    }
}