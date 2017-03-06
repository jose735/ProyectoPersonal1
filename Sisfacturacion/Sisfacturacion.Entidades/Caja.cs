using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Entidades
{
    public class Caja
    {
        public int idCaja { get; set; }
        public String descripcion { get; set; }
        public int idUsuario { get; set; }
        public String nombreCompleto { get; set; }
        public int estado { get; set; }
        public String nombreEstado { get; set; }
    }
}
