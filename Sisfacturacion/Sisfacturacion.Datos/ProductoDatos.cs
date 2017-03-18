using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Datos
{
    public class ProductoDatos
    {
        public List<Producto> SeleccionarProductoPorId(String idProducto)
        {
            List<Producto> lista = new List<Producto>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Id_Producto";
                //El comando es el objeto que ejecuta la sentencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", idProducto);


                // Ejecutar el comando de modo que retorne datos
                SqlDataReader reader = comando.ExecuteReader();



                //lee todas las filas resultado de la consulta
                while (reader.Read())
                {
                    // Se extrae la informacion de la tupla y se convierte a un objeto
                    Producto producto = new Producto();
                    producto.idProducto = reader["idProducto"].ToString();
                    producto.nombre = reader["nombre"].ToString();
                    producto.cantidad = Convert.ToInt32(reader["cantidad"].ToString());
                    producto.precio = Convert.ToDouble(reader["precio"].ToString());
                    producto.fechaIngreso = reader["fechaIngreso"].ToString();
                    producto.fechaVencimiento = reader["fechaVencimiento"].ToString();
                    producto.idCategoria = Convert.ToInt32(reader["idCategoria"].ToString());
                    producto.idProveedor = reader["idProveedor"].ToString();
                    producto.estado = Convert.ToInt32(reader["estado"].ToString());

                    lista.Add(producto);
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

        public List<Producto> SeleccionarProductoPorNombre(String nombre)
        {
            List<Producto> lista = new List<Producto>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Por_Nombre_Producto";
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
                    Producto producto = new Producto();
                    producto.idProducto = reader["idProducto"].ToString();
                    producto.nombre = reader["nombre"].ToString();
                    producto.cantidad = Convert.ToInt32(reader["cantidad"].ToString());
                    producto.precio = Convert.ToDouble(reader["precio"].ToString());
                    producto.fechaIngreso = reader["fechaIngreso"].ToString();
                    producto.fechaVencimiento = reader["fechaVencimiento"].ToString();
                    producto.idCategoria = Convert.ToInt32(reader["idCategoria"].ToString());
                    producto.idProveedor = reader["idProveedor"].ToString();
                    producto.estado = Convert.ToInt32(reader["estado"].ToString());

                    lista.Add(producto);
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

        public List<Producto> SeleccionarTodosProducto()
        {
            List<Producto> lista = new List<Producto>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Producto";
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
                    Producto producto = new Producto();
                    producto.idProducto = reader["Id"].ToString();
                    producto.nombre = reader["Nombre"].ToString();
                    producto.cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                    producto.precio = Convert.ToDouble(reader["Precio"].ToString());
                    producto.fechaIngreso = reader["FechaIngreso"].ToString();
                    producto.fechaVencimiento = reader["FechaVencimiento"].ToString();
                    producto.nombreCategoria = reader["Categoria"].ToString();
                    producto.nombreProveedor = reader["NombreProveedor"].ToString();
                    producto.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (producto.estado == 1)
                    {
                        producto.nombreEstado = "Activo";
                    }
                    else
                    {
                        producto.nombreEstado = "Inactivo";
                    }

                    lista.Add(producto);
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

        public List<Producto> SeleccionarTodosProducto(int estado)
        {
            List<Producto> lista = new List<Producto>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_Producto_2";
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
                    Producto producto = new Producto();
                    producto.idProducto = reader["Id"].ToString();
                    producto.nombre = reader["Nombre"].ToString();
                    producto.cantidad = Convert.ToInt32(reader["Cantidad"].ToString());
                    producto.precio = Convert.ToDouble(reader["Precio"].ToString());
                    producto.fechaIngreso = reader["FechaIngreso"].ToString();
                    producto.fechaVencimiento = reader["FechaVencimiento"].ToString();
                    producto.nombreCategoria = reader["Categoria"].ToString();
                    producto.nombreProveedor = reader["NombreProveedor"].ToString();
                    producto.estado = Convert.ToInt32(reader["Estado"].ToString());
                    if (producto.estado == 1)
                    {
                        producto.nombreEstado = "Activo";
                    }
                    else
                    {
                        producto.nombreEstado = "Inactivo";
                    }

                    lista.Add(producto);
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

        public void Insertar(Producto producto)
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
                string sql = "PA_Insertar_Producto";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", producto.idProducto);
                comando.Parameters.AddWithValue("@nombre", producto.nombre);
                comando.Parameters.AddWithValue("@cantidad", producto.cantidad);
                comando.Parameters.AddWithValue("@precio", producto.precio);
                comando.Parameters.AddWithValue("@fechaIngreso", producto.fechaIngreso);
                comando.Parameters.AddWithValue("@fechaVencimiento", producto.fechaVencimiento);
                comando.Parameters.AddWithValue("@idCategoria", producto.idCategoria);
                comando.Parameters.AddWithValue("@idProveedor", producto.idProveedor);
                comando.Parameters.AddWithValue("@estado", producto.estado);

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

        public void Modificar(Producto producto)
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
                string sql = "PA_Modificar_Producto";
                //El comando es el objeto que ejecuta la sebntencia
                SqlCommand comando = new SqlCommand(sql, conexion);
                // Nota: es obligatorio cambiar el tipo de comando
                comando.CommandType = System.Data.CommandType.StoredProcedure;
                comando.Parameters.AddWithValue("@idProducto", producto.idProducto);
                comando.Parameters.AddWithValue("@nombre", producto.nombre);
                comando.Parameters.AddWithValue("@cantidad", producto.cantidad);
                comando.Parameters.AddWithValue("@precio", producto.precio);
                comando.Parameters.AddWithValue("@fechaIngreso", producto.fechaIngreso);
                comando.Parameters.AddWithValue("@fechaVencimiento", producto.fechaVencimiento);
                comando.Parameters.AddWithValue("@idCategoria", producto.idCategoria);
                comando.Parameters.AddWithValue("@idProveedor", producto.idProveedor);
                comando.Parameters.AddWithValue("@estado", producto.estado);

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
