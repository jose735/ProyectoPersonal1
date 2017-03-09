using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class ProveedorLogica
    {
        public List<Proveedor> ObtenerProveedor(int idProveedor)
        {
            ProveedorDatos datos = new ProveedorDatos();
            return datos.SeleccionarProveedorPorId(idProveedor);
        }

        public List<Proveedor> ObtenerTodosProveedor()
        {
            ProveedorDatos datos = new ProveedorDatos();
            return datos.SeleccionarTodosProveedor();
        }

        public List<Proveedor> ObtenerTodosProveedor(int estado)
        {
            ProveedorDatos datos = new ProveedorDatos();
            return datos.SeleccionarTodosProveedor(estado);
        }

        public void InsertarProveedor(Proveedor proveedor)
        {
            ProveedorDatos datos = new ProveedorDatos();
            datos.Insertar(proveedor);
        }

        public void ModificarProveedor(Proveedor proveedor)
        {
            ProveedorDatos datos = new ProveedorDatos();
            datos.Modificar(proveedor);
        }
    }
}
