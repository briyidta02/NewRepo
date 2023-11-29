using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Soat : ISoat
    {
        private DateTime _fechafinal;
        public DateTime FechaFinal
        {
            get
            {
                return _fechafinal;
            }
            set
            {
                _fechafinal = value;
            }
        }

        private DateTime _Fechaproxima;
        public DateTime FechaProxima
        {
            get
            {
                return _Fechaproxima;
            }
            set
            {
                _Fechaproxima = value;
            }
        }
        private int _Numeroaseguradora;
        internal string Id;

        public int NumeroAseguradora
        {
            get
            {
                return _Numeroaseguradora;
            }
            set
            {
                _Numeroaseguradora = value;
            }
        }

        public Soat(int NumeroAseguradora, DateTime FechaProxima, DateTime FechaFinal)
        {
            _Numeroaseguradora = NumeroAseguradora;
            _Fechaproxima = FechaProxima;
            _fechafinal = FechaFinal;
        }

        public Soat()
        {
            bool continueValidation = true;
            while (continueValidation) {
                Console.WriteLine("Ingrese el numero de aeguradora:");
                try
                {
                    int NumeroAseguradora = int.Parse(Console.ReadLine());
                    DateTime fechaExpedicion = DateTime.Now;
                    DateTime fechVencimiento = DateTime.Now.AddYears(1);
                    _Numeroaseguradora = NumeroAseguradora;
                    _Fechaproxima = fechaExpedicion;
                    _fechafinal = fechVencimiento;
                }
                catch
                {
                    Console.WriteLine("Intente denuevo");
                }
            }


        }

        public Soat Notificacionsoat(Soat soat)
        {
            DateTime now = DateTime.Now;

            DateTime startDate = new DateTime(2021, 10, 21);

            DateTime endDate = new DateTime(2023, 10, 21);

            TimeSpan timeRemaining = endDate - now;

            int daysThreshold = 7;

            if (timeRemaining.TotalDays <= daysThreshold)
            {
                Console.WriteLine($"¡Atención! El SOAT está próximo a vencer en {timeRemaining.TotalDays} días.");
            }
            else
            {
                Console.WriteLine("El SOAT todavía está vigente.");
            }

            throw new NotImplementedException();
        }

        public string FechaProximavencer(Soat soat)
        {

            throw new NotImplementedException();
        }

        public List<Soat> Search(DateTime FechaProxima, DateTime FechaFinal)
        {
            throw new NotImplementedException();
        }
    }
}

