using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class TipoUsuarioLogica
    {
        public List<TipoUsuario> ObtenerTodosUsuarios()
        {
            TipoUsuarioDatos datos = new TipoUsuarioDatos();
            return datos.SeleccionarTodosTipoUsuario();
        }
    }
}
