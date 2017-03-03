using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sisfacturacion.Entidades;
using Sisfacturacion.Datos;

namespace Sisfacturacion.Logica
{
    public class UsuarioLogica
    {
        public List<Usuario> ObtenerUsuario(String nombreUsuario, String contrasenna)
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarUsuarioPorId(nombreUsuario, contrasenna);
        }
    }
}
