using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Mantenimiento
    {
        public class mantenimiento
        {
            private DateTime _Fechainicio
            public DateTime FechaInicio
            {
                get
                {
                    return _Fechainicio;
                }
                set
                {
                    _Fechainicio = value;
                }
            }

            private string MarcaAceite { get; set; }

            private string Servicio { get; set; }
            private double Kilometraje { get; set; }
            private double ProximoCambio { get; set; }
            private double Costo { get; set; }
            private double Lineamientos { get; set; }
            private string NombreTaller { get; set; }
            private string NombreMecanico { get; set; }
            private string Frenos { get; set; }

        }
}
}
