using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Entidades
{
    public class Cancion
    {
        public int idCancion { get; set; }
        public String nombreCancion { get; set; }
        public String rutaCancion { get; set; }
        public int idInterprete { get; set; }
        public String nombreInterprete { get; set; }
        public int idAlbum { get; set; }
        public String nombreAlbum { get; set; }
    }
}
