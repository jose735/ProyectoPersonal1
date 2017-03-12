using Sisfacturacion.Datos;
using Sisfacturacion.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sisfacturacion.Logica
{
    public class ProductoLogica
    {
        public List<Producto> ObtenerProducto(String idProducto)
        {
            ProductoDatos datos = new ProductoDatos();
            return datos.SeleccionarProductoPorId(idProducto);
        }

        public List<Producto> ObtenerTodosProducto()
        {
            ProductoDatos datos = new ProductoDatos();
            return datos.SeleccionarTodosProducto();
        }

        public List<Producto> ObtenerTodosProducto(int estado)
        {
            ProductoDatos datos = new ProductoDatos();
            return datos.SeleccionarTodosProducto(estado);
        }

        public void InsertarProducto(Producto producto)
        {
            ProductoDatos datos = new ProductoDatos();
            datos.Insertar(producto);
        }

        public void ModificarProducto(Producto producto)
        {
            ProductoDatos datos = new ProductoDatos();
            datos.Modificar(producto);
        }

        public double precioRealProducto(double precio, double porcentaje)
        {
            double total = 0;
            double porc = porcentaje / 100;
            total = precio + (precio * porc);
            return total;
        }
    }
}
