using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.linflezRecuperacionC.Servicios
{
    /// <summary>
    /// Implementacion que tiene los métodos de la interfaz del menú.
    /// </summary>
    internal class MenuImplementacion : MenuInterfaz
    {

        public int menuInicial()
        {
            int opcion;
            Console.WriteLine("");
            Console.WriteLine("0. Cerrar Menú");
            Console.WriteLine("1. Numero históricos");
            Console.WriteLine("2. Alta nuevo Propietario");
            opcion = Console.ReadKey(true).KeyChar -('0');


            return opcion;




        }
    }
}
