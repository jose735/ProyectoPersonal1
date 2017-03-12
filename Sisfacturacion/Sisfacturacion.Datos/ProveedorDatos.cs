using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Datos
{
    public class ProveedorDatos
    {
        public List<Proveedor> SeleccionarProveedorPorId(String idProveedor)
        {
            List<Proveedor> lista = new List<Proveedor>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Id_Proveedor";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProveedor", idProveedor);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Proveedor proveedor = new Proveedor();
                    proveedor.idProveedor = reader["idProveedor"].ToString();
                    proveedor.nombre = reader["nombre"].ToString();
                    proveedor.nombreRepartidor = reader["nombreRepartidor"].ToString();
                    proveedor.idCiudad = Convert.ToInt32(reader["idCiudad"].ToString());
                    proveedor.direccionLocal = reader["direccionLocal"].ToString();
                    proveedor.telefono = reader["telefono"].ToString();
                    proveedor.estado = Convert.ToInt32(reader["estado"].ToString());

                    lista.Add(proveedor);
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

        public int SeleccionarProductoPorProveedor(String idProveedor)
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
                string sql = "PA_Seleccionar_Producto_Por_Proveedor";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProveedor", idProveedor);


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

        public List<Proveedor> SeleccionarTodosProveedor()
        {
            List<Proveedor> lista = new List<Proveedor>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Proveedor";
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
                    Proveedor proveedor = new Proveedor();
                    proveedor.idProveedor = reader["Id"].ToString();
                    proveedor.nombre = reader["Nombre"].ToString();
                    proveedor.nombreRepartidor = reader["NombreRepartidor"].ToString();
                    proveedor.nombreCiudad = reader["Descripcion"].ToString();
                    proveedor.direccionLocal = reader["DireccionLocal"].ToString();
                    proveedor.telefono = reader["Telefono"].ToString();
                    proveedor.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (proveedor.estado == 1)
                    {
                        proveedor.nombreEstado = "Activo";
                    }
                    else
                    {
                        proveedor.nombreEstado = "Inactivo";
                    }

                    lista.Add(proveedor);
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

        public List<Proveedor> SeleccionarTodosProveedor(int estado)
        {
            List<Proveedor> lista = new List<Proveedor>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Proveedor_2";
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
                    Proveedor proveedor = new Proveedor();
                    proveedor.idProveedor = reader["Id"].ToString();
                    proveedor.nombre = reader["Nombre"].ToString();
                    proveedor.nombreRepartidor = reader["NombreRepartidor"].ToString();
                    proveedor.nombreCiudad =reader["Descripcion"].ToString();
                    proveedor.direccionLocal = reader["DireccionLocal"].ToString();
                    proveedor.telefono = reader["Telefono"].ToString();
                    proveedor.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (proveedor.estado == 1)
                    {
                        proveedor.nombreEstado = "Activo";
                    }
                    else
                    {
                        proveedor.nombreEstado = "Inactivo";
                    }

                    lista.Add(proveedor);
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

        public void Insertar(Proveedor proveedor)
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
                string sql = "PA_Insertar_Proveedor";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
                comando.Parameters.AddWithValue("@nombre", proveedor.nombre);
                comando.Parameters.AddWithValue("@nombreRepartidor", proveedor.nombreRepartidor);
                comando.Parameters.AddWithValue("@idCiudad", proveedor.idCiudad);
                comando.Parameters.AddWithValue("@direccionLocal", proveedor.direccionLocal);
                comando.Parameters.AddWithValue("@telefono", proveedor.telefono);
                comando.Parameters.AddWithValue("@estado", proveedor.estado);

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

        public void Modificar(Proveedor proveedor)
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
                string sql = "PA_Modificar_Proveedor";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
                comando.Parameters.AddWithValue("@nombre", proveedor.nombre);
                comando.Parameters.AddWithValue("@nombreRepartidor", proveedor.nombreRepartidor);
                comando.Parameters.AddWithValue("@idCiudad", proveedor.idCiudad);
                comando.Parameters.AddWithValue("@direccionLocal", proveedor.direccionLocal);
                comando.Parameters.AddWithValue("@telefono", proveedor.telefono);
                comando.Parameters.AddWithValue("@estado", proveedor.estado);

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
