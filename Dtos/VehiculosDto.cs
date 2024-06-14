using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.linflezRecuperacionC.Dtos
{
    /// <summary>
    /// Clase que contiene los datos de los vehículos.
    /// </summary>
    internal class VehiculosDto
    {

        int idVehiculo;
        string matricula;
        DateTime fchMatriculacion = DateTime.Now;

        public int IdVehiculo { get => idVehiculo; set => idVehiculo = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public DateTime FchMatriculacion { get => fchMatriculacion; set => fchMatriculacion = value; }
    }
}
