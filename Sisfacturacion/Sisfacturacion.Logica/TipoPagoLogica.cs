using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class TipoPagoLogica
    {
        public List<TipoPago> ObtenerTodosTipoPago()
        {
            TipoPagoDatos datos = new TipoPagoDatos();
            return datos.SeleccionarTodosTipoPago();
        }
    }
}
