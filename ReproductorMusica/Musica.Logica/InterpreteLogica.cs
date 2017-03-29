using Musica.Datos;
using Musica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Logica
{
    public class InterpreteLogica
    {
        public Boolean existe(String nombre)
        {
            Boolean siExiste = false;
            InterpreteDatos datos = new InterpreteDatos();
            if (datos.SeleccionarPorIdInterprete(nombre).Count > 0)
            {
                siExiste = true;
            }
            else
            {
                siExiste = false;
            }
            return siExiste;
        }

        public List<Interprete> ObtenerTodosInterprete()
        {
            InterpreteDatos datos = new InterpreteDatos();
            return datos.SeleccionarTodosInterprete();
        }

        public void InsertarInterprete(Interprete interprete)
        {
            InterpreteDatos datos = new InterpreteDatos();
            datos.Insertar(interprete);
        }
    }
}
