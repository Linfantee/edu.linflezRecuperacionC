using edu.linflezrecuperacionC;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.linflezRecuperacionC.Servicios
{
    /// <summary>
    /// Implementación que contiene los métodos de los ficheros.
    /// </summary>
    internal class FicheroImplementacion : FicheroInterfaz
    {

        public string escribirFichero(string mensaje)
        {
            StreamWriter sw = null;
            try
            {
                sw = new StreamWriter(Program.rutaCompletaLog, true);
                sw.WriteLine(mensaje);


            }
            catch (Exception e)
            {
                Console.WriteLine("Se ha producido un error, vuelva en 10 min.");
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }

            }
            return mensaje;
        }


        public string cargaInicial()
        {
            try
            {








            }catch (Exception e)
            {

                Console.WriteLine("Se ha producido un error, vuelva en 10 min.");

            }




        }

    }
}
