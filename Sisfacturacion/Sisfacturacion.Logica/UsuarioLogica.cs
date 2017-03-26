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

        public List<Usuario> ObtenerUsuario(String nombreUsuario)
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarUsuarioPorId(nombreUsuario);
        }

        public int ObtenerCajaPorUsuario(String nombreUsuario)
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarCajaPorUsuario(nombreUsuario);
        }

        public List<Caja> ObtenerCajaPorUsuario2(String nombreUsuario)
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarCajaPorUsuario2(nombreUsuario);
        }

        public List<Usuario> ObtenerTodosUsuarios()
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarTodosUsuario();
        }

        public List<Usuario> ObtenerTodosUsuarios(int estado)
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarTodosUsuario(estado);
        }

        public List<Usuario> ObtenerTodosUsuarios2()
        {
            UsuarioDatos datos = new UsuarioDatos();
            return datos.SeleccionarTodosUsuario2();
        }

        public void InsertarUsuario(Usuario usuario)
        {
            UsuarioDatos datos = new UsuarioDatos();
            datos.Insertar(usuario);
        }

        public void ModificarUsuario(Usuario usuario)
        {
            UsuarioDatos datos = new UsuarioDatos();
            datos.Modificar(usuario);
        }

        public void ModificarUsuario2(Usuario usuario)
        {
            UsuarioDatos datos = new UsuarioDatos();
            datos.Modificar2(usuario);
        }

        public void EliminarUsuario(String nombreUsuario)
        {
            UsuarioDatos datos = new UsuarioDatos();
            datos.Eliminar(nombreUsuario);
        }
    }
}
