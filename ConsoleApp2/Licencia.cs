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
        private String _Fechavigencia;
        public String FechaVigencia
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


        private String _Fechaexpediente;
        public String FechaExpediente
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
       
  
        private string _Servicio;
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

        public Licencia(int IdentificacionPersona, String FechaVigencia, String FechaExpediente, string Servicio, string NombreConductor) {

            _Identificacionpersona = IdentificacionPersona;
            _Fechavigencia = FechaVigencia;
            _Fechaexpediente = FechaExpediente;
            _Servicio = Servicio;
            _Nombreconductor = NombreConductor;

        }
    }
}

