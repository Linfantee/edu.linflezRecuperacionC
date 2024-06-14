using edu.linflezrecuperacionC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.linflezRecuperacionC.Servicios
{
    /// <summary>
    /// Implementación que tiene los métodos de la operativa
    /// </summary>
    internal class OperativaImplementacion : OperativaInterfaz
    {

        private int idAutomatico()
        {
            int id;

            id = 0;



            return id;
        }

        public string darAlta()
        {

            string nuevopropietario = " ";

            Console.WriteLine("Introduzca su DNI por favor.");
            string dni = Console.ReadLine();


            return nuevopropietario;


        }

    }
}
