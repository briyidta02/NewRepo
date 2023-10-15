using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Soat
    {
        private string _fechafinal;
        public string FechaFinal
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

        private String _Fechaproxima;
        public string FechaProxima
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
        private int _Numerosoat;
        public int NumeroSoat
        {
            get
            {
                return _Numerosoat;
            }
            set
            {
                _Numerosoat = value;
            }
        }
    
        public Soat(int NumeroSoat, String FechaProxima,string FechaFinal)
        {
            _Numerosoat = NumeroSoat;
            _Fechaproxima = FechaProxima;
            _fechafinal = FechaFinal;
        }
    }
}


