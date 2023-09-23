using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Licencia
    {

        private int _Identificacionpersona;
        public int IdentificacionPersona
        {
            get
            {
                return _Identificacionpersona;
            }
            set
            {
                _Identificacionpersona = value;
            }
        }
        private DateTime _Fechavigencia;
        public DateTime FechaVigencia
        {
            get
            {
                return _Fechavigencia;
            }
            set
            {
                _Fechavigencia = value;
            }
        }


        private DateTime _Fechaexpediente { get; set; }
        public DateTime FechaExpediente
        {
            get
            {
                return _Fechaexpediente;
            }
            set
            {
                _Fechaexpediente = value;
            }
        }
        private string _Clasevehiculo { get; set; }

        public string ClaseVehiculo
        {
            get
            {
                return _Clasevehiculo;
            }
            set
            {
                _Clasevehiculo = value;
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

        private string _Nombreconductor;
         
        public string NombreConductor
        {
            get
            {
                return _Nombreconductor;
            }
            set
            {
                _Nombreconductor = value;
            }
        }
    }
}

