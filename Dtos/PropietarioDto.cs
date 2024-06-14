using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace edu.linflezRecuperacionC.Dtos
{
    /// <summary>
    /// Clase que contiene los datos de los propietarios.
    /// </summary>
    internal class PropietarioDto
    {
        int idPropietario;
        string dni;
        DateTime fchCompra = DateTime.Now;
        string matricula;
        string esHistorico;

        public int IdPropietario { get => idPropietario; set => idPropietario = value; }
        public string Dni { get => dni; set => dni = value; }
        public DateTime FchCompra { get => fchCompra; set => fchCompra = value; }
        public string Matricula { get => matricula; set => matricula = value; }
        public string EsHistorico { get => esHistorico; set => esHistorico = value; }
    }
}
