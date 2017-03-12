using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class CategoriaProductoLogica
    {
        public List<CategoriaProducto> ObtenerTodosCategoriaProducto()
        {
            CategoriaProductoDatos datos = new CategoriaProductoDatos();
            return datos.SeleccionarTodosCategoriaProducto();
        }
    }
}
