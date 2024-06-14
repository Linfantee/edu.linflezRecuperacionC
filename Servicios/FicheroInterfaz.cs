using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.linflezRecuperacionC.Servicios
{
    /// <summary>
    /// Interfaz que contiene la cabecera de los ficheros
    /// </summary>
    internal interface FicheroInterfaz
    {
        /// <summary>
        /// Método que crea un fichero y escribe en él.
        /// </summary>
        /// <returns></returns>
        public string escribirFichero(string mensaje);

        /// <summary>
        /// Método que añade datos directamente sin que el usuario lo sepa.
        /// </summary>
        /// <returns></returns>
        public string cargaInicial();
    }
}
