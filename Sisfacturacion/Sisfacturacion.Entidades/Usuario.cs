using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Entidades
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public String nombreUsuario { get; set; }
        public String contrasenna { get; set; }
        public String nombreCompleto { get; set; }
        public int idTipoUsuario { get; set; }
        public String nombreTipoUsuario { get; set; }
        public int estado { get; set; }
        public String nombreEstado { get; set; }
    }
}
