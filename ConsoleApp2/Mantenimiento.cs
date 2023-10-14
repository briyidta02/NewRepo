using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Mantenimiento
    {
        public class mantenimiento
        {
            private DateTime _Fechainicio;
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

            private string _Marcasceite;
                  public string MarcaAceite
            {
                get
                {
                    return _Marcasceite;
                }
                set
                {
                    _Marcasceite = value;
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
            private double _Kilometraje;
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
            private double _Proximocambio;
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
            private double _Costo;
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
            private double _Lineamientos;
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
            private string _Nombretaller;
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
            private string _Nombremecanico;
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
            private string _Frenos;
                  public string Frenos
            {
                get
                {
                    return _Frenos;
                }
                set
                {
                    _Frenos = value;
                }
            }

            public mantenimiento (DateTime FechaInicio, string MarcaAceite, string Servicio, double Kilometraje, double ProximoCambio, double Costo, double Lineamiento, string NombreTaller, string NombreMecanico, string Frenos)
            {
                _Fechainicio = FechaInicio;
                _Marcasceite = MarcaAceite;
                _Servicio = Servicio;
                _Kilometraje = Kilometraje;
                _Proximocambio = ProximoCambio;
                _Costo = Costo;
                _Lineamientos = Lineamiento;
                _Nombretaller = NombreTaller;
                _Nombremecanico = NombreMecanico;
                _Frenos = Frenos;



            }
        }
    }
}


