using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class CajaLogica
    {
        public List<Caja> ObtenerCaja(String descripcion)
        {
            CajaDatos datos = new CajaDatos();
            return datos.SeleccionarCajaPorId(descripcion);
        }

        public List<Caja> ObtenerTodosCajas()
        {
            CajaDatos datos = new CajaDatos();
            return datos.SeleccionarTodosCaja();
        }

        public List<Caja> ObtenerTodosCajas(int estado)
        {
            CajaDatos datos = new CajaDatos();
            return datos.SeleccionarTodosCaja(estado);
        }

        public void InsertarCaja(Caja caja)
        {
            CajaDatos datos = new CajaDatos();
            datos.Insertar(caja);
        }

        public void ModificarCaja(Caja caja)
        {
            CajaDatos datos = new CajaDatos();
            datos.Modificar(caja);
        }

        public void EliminarCaja(String descripcion)
        {
            CajaDatos datos = new CajaDatos();
            datos.Eliminar(descripcion);
        }
    }
}
