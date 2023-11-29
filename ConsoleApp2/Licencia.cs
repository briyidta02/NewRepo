using ConsoleApp2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Licencia: ILicencia
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


        private DateTime _Fechaexpediente;
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
        internal string Id;

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

        public Licencia(int IdentificacionPersona, DateTime FechaVigencia, DateTime FechaExpediente, string Servicio, string NombreConductor) {

            _Identificacionpersona = IdentificacionPersona;
            _Fechavigencia = FechaVigencia;
            _Fechaexpediente = FechaExpediente;
            _Servicio = Servicio;
            _Nombreconductor = NombreConductor;

        }

        public Licencia RegistroLicencia(Licencia licencia)
        {
            public static void RegistrarLicencia()
            {
                Console.Write("Ingrese el numero de licencia: ");
                string licencia = Console.ReadLine();


                Console.Write("Ingrese la fecha de expediecion(YYYY-MM-DD): ");
                DateTime FechaVigencia = DateTime.Parse(Console.ReadLine());

                Console.Write("Ingrese la fecha de vencimiento(YYYY-MM-DD): ");
                DateTime FechaExpediente = DateTime.Parse(Console.ReadLine());
            
                Revision fechaslicencias = new Revision(descripcion, fecha);
                LicenciaDataManager.AddLicencia(fechaslicencias);

                Console.WriteLine("Revisión registrada con éxito.");
                throw new NotImplementedException();
                throw new NotImplementedException();
        }

        public Licencia Renovacion(Licencia licencia)
        {
            throw new NotImplementedException();
        }

        public List<Licencia> Search(DateTime FechaVigencia, DateTime FechaExpediente)
        {
            throw new NotImplementedException();
        }
    }


