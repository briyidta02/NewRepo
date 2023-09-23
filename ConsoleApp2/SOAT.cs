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
            private DateTime _fechaFinal;
            public DateTime FechaFinal
            {
                get
                {
                    return _fechaFinal;
                }
                set
                {
                    _fechaFinal = value;
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

        }



    }
    }

