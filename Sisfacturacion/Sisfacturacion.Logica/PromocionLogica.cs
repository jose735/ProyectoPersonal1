using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class PromocionLogica
    {
        public List<Promocion> ObtenerPromocion(String idProducto, int estado)
        {
            PromocionDatos datos = new PromocionDatos();
            return datos.SeleccionarPromocionPorId(idProducto, estado);
        }

        public List<Promocion> ObtenerTodosPromocion()
        {
            PromocionDatos datos = new PromocionDatos();
            return datos.SeleccionarTodosPromocion();
        }

        public List<Promocion> ObtenerTodosPromocion(int estado)
        {
            PromocionDatos datos = new PromocionDatos();
            return datos.SeleccionarTodosPromocion(estado);
        }

        public void InsertarProveedor(Promocion promocion)
        {
            PromocionDatos datos = new PromocionDatos();
            datos.Insertar(promocion);
        }

        public void ModificarPromocion(Promocion promocion)
        {
            PromocionDatos datos = new PromocionDatos();
            datos.Modificar(promocion);
        }
    }
}
