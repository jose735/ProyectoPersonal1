using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class CiudadLogica
    {
        public List<Ciudad> ObtenerCiudad(int idCiudad)
        {
            CiudadDatos datos = new CiudadDatos();
            return datos.SeleccionarCiudadPorId(idCiudad);
        }

        public List<Ciudad> ObtenerTodosCiudad()
        {
            CiudadDatos datos = new CiudadDatos();
            return datos.SeleccionarTodosCiudad();
        }

        public List<Ciudad> ObtenerTodosCiudad(int estado)
        {
            CiudadDatos datos = new CiudadDatos();
            return datos.SeleccionarTodosCiudad(estado);
        }

        public void InsertarCiudad(Ciudad ciudad)
        {
            CiudadDatos datos = new CiudadDatos();
            datos.Insertar(ciudad);
        }

        public void ModificarCiudad(Ciudad ciudad)
        {
            CiudadDatos datos = new CiudadDatos();
            datos.Modificar(ciudad);
        }
    }
}
