using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Soat
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
    }
}


