using Musica.Datos;
using Musica.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Logica
{
    public class AlbumLogica
    {
        public Boolean existe(String nombre)
        {
            Boolean siExiste = false;
            AlbumDatos datos = new AlbumDatos();
            if (datos.SeleccionarPorIdAlbum(nombre).Count > 0)
            {
                siExiste = true;
            }
            else
            {
                siExiste = false;
            }
            return siExiste;
        }

        public List<Album> ObtenerTodosAlbum()
        {
            AlbumDatos datos = new AlbumDatos();
            return datos.SeleccionarTodosAlbum();
        }

        public void InsertarInterprete(Album album)
        {
            AlbumDatos datos = new AlbumDatos();
            datos.Insertar(album);
        }
    }
}
