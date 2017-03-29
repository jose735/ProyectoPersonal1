using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Musica.Datos
{
    class Conexion
    {
        public static string Cadena
        {
            get
            {
                return ConfigurationManager.ConnectionStrings["Default"].ConnectionString;
            }
        }

        // Pasos para obtener la cadena de nonexion desde el app.config
        // Paso 1 : Agregar la referencia System.Configuration
        // Paso 2 : Agregar el using de System.Configuration
        // Paso 3 : Usar la clase ConfigurationManager
    }
}
