using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class ClienteLogica
    {
        public List<Cliente> ObtenerCliente(int idCliente)
        {
            ClienteDatos datos = new ClienteDatos();
            return datos.SeleccionarClientePorId(idCliente);
        }

        public List<Cliente> ObtenerTodosCliente()
        {
            ClienteDatos datos = new ClienteDatos();
            return datos.SeleccionarTodosCliente();
        }

        public void InsertarCliente(Cliente cliente)
        {
            ClienteDatos datos = new ClienteDatos();
            datos.Insertar(cliente);
        }

        public void ModificarCliente(Cliente cliente)
        {
            ClienteDatos datos = new ClienteDatos();
            datos.Modificar(cliente);
        }
    }
}
