using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.linflezRecuperacionC.Utiles
{
    internal class Util
    {

        public static string crearNombreLog()
        {
            string fechaTotal = "";
            try
            {

                DateTime fecha = DateTime.Now;
                string fechaConvertida = Convert.ToString(fecha.ToString("ddMMyyyy"));
                fechaTotal = String.Concat("log-", fechaConvertida, ".txt");



            }catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            return fechaTotal;


        }

    }
}
