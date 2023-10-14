using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class SOAT
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

            public Soat(int NumeroSoat, DateTime FechaProxima, DateTime FechaFinal)
            {
                _Numerosoat = NumeroSoat;
                _Fechaproxima = FechaProxima;
                _fechafinal = FechaFinal;
            }
        }

        
    }
}

