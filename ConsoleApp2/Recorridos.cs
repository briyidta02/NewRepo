using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Recorridos
    {
        internal string Id;
        private int _Recorrido;
        public int Recorrido
        {
            get
            {
                return _Recorrido;
            }
            set
            {
                _Recorrido = value;
            }
        }

    }
}
