﻿using Musica.Datos;
using Musica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Logica
{
    public class CancionLogica
    {
        public Boolean existe(String nombre, int idAlbum, int idInterprete)
        {
            Boolean siExiste = false;
            CancionDatos datos = new CancionDatos();
            if (datos.SeleccionarPorIdCancion(nombre, idAlbum, idInterprete).Count > 0)
            {
                siExiste = true;
            }
            else
            {
                siExiste = false;
            }
            return siExiste;
        }

        public List<Cancion> ObtenerTodosCancion()
        {
            CancionDatos datos = new CancionDatos();
            return datos.SeleccionarTodosCancion();
        }

        public List<Cancion> ObtenerPorAlbumCancion(int idAlbum)
        {
            CancionDatos datos = new CancionDatos();
            return datos.SeleccionarCancionPorAlbum(idAlbum);
        }

        public List<Cancion> ObtenerPorInterpreteCancion(int idInterprete)
        {
            CancionDatos datos = new CancionDatos();
            return datos.SeleccionarCancionPorInterprete(idInterprete);
        }

        public void InsertarCancion(Cancion cancion)
        {
            CancionDatos datos = new CancionDatos();
            datos.Insertar(cancion);
        }

        public List<Cancion> ObtenerPorNombreCancion(String nombre)
        {
            CancionDatos datos = new CancionDatos();
            return datos.SeleccionarPorNombreCancion(nombre);
        }
    }
}
