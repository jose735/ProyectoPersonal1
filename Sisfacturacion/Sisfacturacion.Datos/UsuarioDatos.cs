using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sisfacturacion.Entidades;
using System.Data.SqlClient;

namespace Sisfacturacion.Datos
{
    public class UsuarioDatos
    {
        public List<Usuario> SeleccionarUsuarioPorId(String nombreUsuario, String contrasenna)
        {
            List<Usuario> lista = new List<Usuario>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Id_Usuario";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                comando.Parameters.AddWithValue("@contrasenna", Seguridad.Encriptar(contrasenna));


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Usuario usuario = new Usuario();
                    usuario.idUsuario = Convert.ToInt32(reader["idUsuario"].ToString());
                    usuario.nombreUsuario = reader["nombreUsuario"].ToString();
                    usuario.contrasenna = Seguridad.DesEncriptar(reader["contrasenna"].ToString());
                    usuario.nombreCompleto = reader["nombreCompleto"].ToString();
                    usuario.idTipoUsuario = Convert.ToInt32(reader["idTipoUsuario"].ToString());
                    usuario.estado = Convert.ToInt32(reader["estado"].ToString());

                    lista.Add(usuario);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

        }

        public List<Usuario> SeleccionarUsuarioPorId(String nombreUsuario)
        {
            List<Usuario> lista = new List<Usuario>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Id_Usuario_2";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Usuario usuario = new Usuario();
                    usuario.idUsuario = Convert.ToInt32(reader["idUsuario"].ToString());
                    usuario.nombreUsuario = reader["nombreUsuario"].ToString();
                    usuario.contrasenna = Seguridad.DesEncriptar(reader["contrasenna"].ToString());
                    usuario.nombreCompleto = reader["nombreCompleto"].ToString();
                    usuario.idTipoUsuario = Convert.ToInt32(reader["idTipoUsuario"].ToString());

                    lista.Add(usuario);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

        }

        public int SeleccionarCajaPorUsuario(String nombreUsuario)
        {
            int cont = 0;
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Caja_Por_Usuario";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    cont++;
                }

                return cont;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

        }

        public List<Caja> SeleccionarCajaPorUsuario2(String nombreUsuario)
        {
            List<Caja> lista = new List<Caja>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Caja_Por_Usuario_2";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Caja caja = new Caja();
                    caja.idCaja = Convert.ToInt32(reader["idCaja"].ToString());
                    caja.descripcion = reader["descripcion"].ToString();
                    caja.idUsuario = Convert.ToInt32(reader["idUsuario"].ToString());

                    lista.Add(caja);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

        }

        public List<Usuario> SeleccionarTodosUsuario()
        {
            List<Usuario> lista = new List<Usuario>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Usuario";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Usuario usuario = new Usuario();
                    usuario.idUsuario = Convert.ToInt32(reader["Id"].ToString());
                    usuario.nombreUsuario = reader["NombreUsuario"].ToString();
                    usuario.contrasenna = reader["Contrasena"].ToString();
                    usuario.nombreCompleto = reader["NombreCompleto"].ToString();
                    usuario.nombreTipoUsuario = reader["TipoUsuario"].ToString();
                    usuario.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (usuario.estado == 1)
                    {
                        usuario.nombreEstado = "Activo";
                    }
                    else
                    {
                        usuario.nombreEstado = "Inactivo";
                    }

                    lista.Add(usuario);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

        }

        public List<Usuario> SeleccionarTodosUsuario(int estado)
        {
            List<Usuario> lista = new List<Usuario>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Usuario_3";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@estado", estado);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Usuario usuario = new Usuario();
                    usuario.idUsuario = Convert.ToInt32(reader["Id"].ToString());
                    usuario.nombreUsuario = reader["NombreUsuario"].ToString();
                    usuario.contrasenna = reader["Contrasena"].ToString();
                    usuario.nombreCompleto = reader["NombreCompleto"].ToString();
                    usuario.nombreTipoUsuario = reader["TipoUsuario"].ToString();
                    usuario.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (usuario.estado == 1)
                    {
                        usuario.nombreEstado = "Activo";
                    }
                    else
                    {
                        usuario.nombreEstado = "Inactivo";
                    }

                    lista.Add(usuario);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

        }

        public List<Usuario> SeleccionarTodosUsuario2()
        {
            List<Usuario> lista = new List<Usuario>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Usuario_2";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Usuario usuario = new Usuario();
                    usuario.idUsuario = Convert.ToInt32(reader["idUsuario"].ToString());
                    usuario.nombreUsuario = reader["nombreUsuario"].ToString();
                    usuario.contrasenna = Seguridad.DesEncriptar(reader["contrasenna"].ToString());
                    usuario.nombreCompleto = reader["nombreCompleto"].ToString();
                    usuario.idTipoUsuario = Convert.ToInt32(reader["idTipoUsuario"].ToString());
                    usuario.estado = Convert.ToInt32(reader["estado"].ToString());

                    lista.Add(usuario);
                }

                return lista;
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                conexion.Close();
            }

        }

        public void Insertar(Usuario usuario)
        {
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Insertar_Usuario";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                comando.Parameters.AddWithValue("@contrasenna", Seguridad.Encriptar(usuario.contrasenna));
                comando.Parameters.AddWithValue("@nombreCompleto", usuario.nombreCompleto);
                comando.Parameters.AddWithValue("@idTipoUsuario", usuario.idTipoUsuario);
                comando.Parameters.AddWithValue("@estado", usuario.estado);

                // Ejecutar el comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
        }

        public void Modificar(Usuario usuario)
        {
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Modificar_Usuario";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                comando.Parameters.AddWithValue("@contrasenna", Seguridad.Encriptar(usuario.contrasenna));

                // Ejecutar el comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
        }

        public void Modificar2(Usuario usuario)
        {
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Modificar_Usuario_2";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", usuario.nombreUsuario);
                comando.Parameters.AddWithValue("@estado", usuario.estado);

                // Ejecutar el comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
        }

        public void Eliminar(String nombreUsuario)
        {
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Eliminar_Usuario";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);

                // Ejecutar el comando
                comando.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }

            finally
            {
                conexion.Close();
            }
        }
    }
}
