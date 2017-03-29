using Musica.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Datos
{
    public class CancionDatos
    {
        public void Insertar(Cancion cancion)
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
                string sql = "PA_Insertar_Cancion";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", cancion.nombreCancion);
                comando.Parameters.AddWithValue("@ruta", cancion.rutaCancion);
                comando.Parameters.AddWithValue("@idAlbum", cancion.idAlbum);
                comando.Parameters.AddWithValue("@idInterprete", cancion.idInterprete);

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

        public List<Cancion> SeleccionarTodosCancion()
        {
            List<Cancion> lista = new List<Cancion>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Cancion";
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
                    Cancion cancion = new Cancion();
                    cancion.idCancion = Convert.ToInt32(reader["Id"].ToString());
                    cancion.nombreCancion = reader["Nombre"].ToString();
                    cancion.rutaCancion = reader["Ruta"].ToString();
                    cancion.idAlbum = Convert.ToInt32(reader["IdAlbum"].ToString());
                    cancion.nombreAlbum = reader["NombreAlbum"].ToString();
                    cancion.idInterprete = Convert.ToInt32(reader["IdInterprete"].ToString());
                    cancion.nombreInterprete = reader["NombreInterprete"].ToString();

                    lista.Add(cancion);
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

        public List<Cancion> SeleccionarPorIdCancion(String nombre, int idAlbum, int idInterprete)
        {
            List<Cancion> lista = new List<Cancion>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Id_Cancion";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@idAlbum", idAlbum);
                comando.Parameters.AddWithValue("@idInterprete", idInterprete);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Cancion cancion = new Cancion();
                    cancion.idCancion = Convert.ToInt32(reader["Id"].ToString());
                    cancion.nombreCancion = reader["Nombre"].ToString();
                    cancion.rutaCancion = reader["Ruta"].ToString();
                    cancion.idAlbum = Convert.ToInt32(reader["IdAlbum"].ToString());
                    cancion.nombreAlbum = reader["NombreAlbum"].ToString();
                    cancion.idInterprete = Convert.ToInt32(reader["IdInterprete"].ToString());
                    cancion.nombreInterprete = reader["NombreInterprete"].ToString();

                    lista.Add(cancion);
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

        public List<Cancion> SeleccionarCancionPorAlbum(String nombre)
        {
            List<Cancion> lista = new List<Cancion>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Album_Cancion";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Cancion cancion = new Cancion();
                    cancion.idCancion = Convert.ToInt32(reader["Id"].ToString());
                    cancion.nombreCancion = reader["Nombre"].ToString();
                    cancion.rutaCancion = reader["Ruta"].ToString();
                    cancion.idAlbum = Convert.ToInt32(reader["IdAlbum"].ToString());
                    cancion.nombreAlbum = reader["NombreAlbum"].ToString();
                    cancion.idInterprete = Convert.ToInt32(reader["IdInterprete"].ToString());
                    cancion.nombreInterprete = reader["NombreInterprete"].ToString();

                    lista.Add(cancion);
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

        public List<Cancion> SeleccionarCancionPorInterprete(String nombre)
        {
            List<Cancion> lista = new List<Cancion>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Interprete_Cancion";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@nombre", nombre);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Cancion cancion = new Cancion();
                    cancion.idCancion = Convert.ToInt32(reader["Id"].ToString());
                    cancion.nombreCancion = reader["Nombre"].ToString();
                    cancion.rutaCancion = reader["Ruta"].ToString();
                    cancion.idAlbum = Convert.ToInt32(reader["IdAlbum"].ToString());
                    cancion.nombreAlbum = reader["NombreAlbum"].ToString();
                    cancion.idInterprete = Convert.ToInt32(reader["IdInterprete"].ToString());
                    cancion.nombreInterprete = reader["NombreInterprete"].ToString();

                    lista.Add(cancion);
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
    }
}
