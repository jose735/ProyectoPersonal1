﻿using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Datos
{
    public class CategoriaProductoDatos
    {
        public List<CategoriaProducto> SeleccionarTodosCategoriaProducto()
        {
            List<CategoriaProducto> lista = new List<CategoriaProducto>();
            //Creamos el objeto que se conecta con la base de datos
            //Es necesario enciarle la cadena de conexion para que
            //conozca cual es la base de datos
            SqlConnection conexion = new SqlConnection(Conexion.Cadena);

            try
            {
                // Se debe abrir la conexión
                conexion.Open();
                //Sentencia que se necesita ejecutar
                string sql = "PA_Seleccionar_CategoriaProducto";
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
                    CategoriaProducto categoriaProducto = new CategoriaProducto();
                    categoriaProducto.idCategoriaProducto = Convert.ToInt32(reader["idCategoriaProducto"].ToString());
                    categoriaProducto.descripcion = reader["descripcion"].ToString();

                    lista.Add(categoriaProducto);
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