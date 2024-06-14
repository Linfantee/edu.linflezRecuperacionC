using edu.linflezRecuperacionC.Utiles;
using edu.linflezRecuperacionC.Servicios;
using edu.linflezRecuperacionC.Dtos;


namespace edu.linflezrecuperacionC;


/// <summary>
/// Clase principal de la aplicación
/// leig - 140624
/// </summary>
class Program
{
    /// <summary>
    /// Se encuentran los métodos estáticos y sus cabeceras.
    /// </summary>

    public static string rutaCompletaLog = String.Concat("C:\\Users\\csi23-linflez\\source\\repos\\edu.linflezRecuperacionC\\Logs\\", Util.crearNombreLog());
    public static List<VehiculosDto> listaVehiculos = new List<VehiculosDto>();
    public static List<PropietarioDto> listaPropietarios = new List<PropietarioDto>();
    public static string rutaCargaFichero = String.Concat("C:\\Users\\csi23-linflez\\source\\repos\\edu.linflezRecuperacionC\\CargaInicial", "datosiniciales.txt");


    public static void Main(string[] args)
    {

        MenuInterfaz mi = new MenuImplementacion();
        FicheroInterfaz fi = new FicheroImplementacion();
        OperativaInterfaz oi = new OperativaImplementacion();

        int eleccion;
        bool cerrarMenu = true;


        try
        {
            do
            {

                eleccion = mi.menuInicial();

                switch (eleccion)
                {
                    case 0:
                        Console.WriteLine("Se ha cerrado el menú.");
                        fi.escribirFichero("Se ha cerrado el menú.");
                        cerrarMenu = false;
                        break;
                    case 1:
                        Console.WriteLine("Se muestra el número de históricos");
                        fi.escribirFichero("Se muestra el número de históricos");
                        break;
                    case 2:
                        Console.WriteLine("Dando de alta a un nuevo propietario");
                        fi.escribirFichero("Dando de alta a un nuevo propietario");
                        break;
                    default:
                        Console.WriteLine("La opción escogida no es valida elija otra por favor.");
                        fi.escribirFichero("Se ha producido un error, vuelva en 10 min.");
                        break;


                }

            }while(cerrarMenu);

        }catch (Exception e)
        {
            Console.WriteLine("Se ha producido un error, vuelva en 10 min.");
            fi.escribirFichero("Se ha producido un error, vuelva en 10 min.");
        }









    }



}
