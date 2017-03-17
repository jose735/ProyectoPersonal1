using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Datos
{
    public class PromocionDatos
    {
        public List<Promocion> SeleccionarPromocionPorId(String idProducto, int estado)
        {
            List<Promocion> lista = new List<Promocion>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Id_Promocion";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", idProducto);
                comando.Parameters.AddWithValue("@estado", estado);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Promocion promocion = new Promocion();
                    promocion.idPromocion = Convert.ToInt32(reader["Id"].ToString());
                    promocion.idProducto = reader["IdProducto"].ToString();
                    promocion.nombreProducto = reader["NombreProducto"].ToString();
                    promocion.precio = Convert.ToDouble(reader["Precio"].ToString());
                    promocion.cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                    promocion.porcentajeDescuento = Convert.ToDouble(reader["PorcentajeDescuento"].ToString());
                    promocion.estado = Convert.ToInt32(reader["Estado"].ToString());

                    lista.Add(promocion);
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

        public List<Promocion> SeleccionarTodosPromocion()
        {
            List<Promocion> lista = new List<Promocion>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Promocion";
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
                    Promocion promocion = new Promocion();
                    promocion.idPromocion = Convert.ToInt32(reader["Id"].ToString());
                    promocion.idProducto = reader["IdProducto"].ToString();
                    promocion.nombreProducto = reader["NombreProducto"].ToString();
                    promocion.porcentajeDescuento = Convert.ToDouble(reader["PorcentajeDescuento"].ToString());
                    promocion.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (promocion.estado == 1)
                    {
                        promocion.nombreEstado = "Activo";
                    }
                    else
                    {
                        promocion.nombreEstado = "Inactivo";
                    }

                    lista.Add(promocion);
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

        public List<Promocion> SeleccionarTodosPromocion(int estado)
        {
            List<Promocion> lista = new List<Promocion>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Promocion_2";
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
                    Promocion promocion = new Promocion();
                    promocion.idPromocion = Convert.ToInt32(reader["Id"].ToString());
                    promocion.idProducto = reader["IdProducto"].ToString();
                    promocion.nombreProducto = reader["NombreProducto"].ToString();
                    promocion.porcentajeDescuento = Convert.ToDouble(reader["PorcentajeDescuento"].ToString());
                    promocion.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (promocion.estado == 1)
                    {
                        promocion.nombreEstado = "Activo";
                    }
                    else
                    {
                        promocion.nombreEstado = "Inactivo";
                    }

                    lista.Add(promocion);
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

        public void Insertar(Promocion promocion)
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
                string sql = "PA_Insertar_Promocion";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", promocion.idProducto);
                comando.Parameters.AddWithValue("@porcentajeDescuento", promocion.porcentajeDescuento);
                comando.Parameters.AddWithValue("@estado", promocion.estado);

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

        public void Modificar(Promocion promocion)
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
                string sql = "PA_Modificar_Promocion";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idPromocion", promocion.idPromocion);
                comando.Parameters.AddWithValue("@porcentajeDescuento", promocion.porcentajeDescuento);
                comando.Parameters.AddWithValue("@estado", promocion.estado);

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
