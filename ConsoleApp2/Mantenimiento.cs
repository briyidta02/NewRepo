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

            private string _Marcasceite { get; set; }
            public string MarcaAceite 
            {
                get
                {
                    return _Marcasceite;
                }
                set
                {
                    _Marcasceite  = value;
                }
            }
            private string _Servicio { get; set; }
            public string Servicio
            {
                get
                {
                    return _Servicio;
                }
                set
                {
                    _Servicio = value;
                }
            }
            private double _Kilometraje { get; set; }
            public double Kilometraje
            {
                get
                {
                    return _Kilometraje;
                }
                set
                {
                    _Kilometraje = value;
                }
            }
            private double _Proximocambio { get; set; }
            public double ProximoCambio
            {
                get
                {
                    return _Proximocambio;
                }
                set
                {
                    _Proximocambio = value;
                }
            }
            private double _Costo { get; set; }
            public double Costo
            {
                get
                {
                    return _Costo;
                }
                set
                {
                    _Costo = value;
                }
            }
            private double _Lineamientos { get; set; }
            public double Lineamiento
            {
                get
                {
                    return _Lineamientos;
                }
                set
                {
                    _Lineamientos = value;
                }
            }
            private string _Nombretaller { get; set; }
            public string NombreTaller
            {
                get
                {
                    return _Nombretaller;
                }
                set
                {
                    _Nombretaller = value;
                }
            }
            private string _Nombremecanico { get; set; }
            public string NombreMecanico
            {
                get
                {
                    return _Nombremecanico;
                }
                set
                {
                    _Nombremecanico = value;
                }
            }
            private string _Frenos { get; set; }
            public string Frenos
            {
                get
                {
                    return _Frenos;
                }
                set
                {
                    _Frenos= value;
                }
            }
        }
}
}
