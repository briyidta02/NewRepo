using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Vehiculo: VehiculoAutomotor
    {
        public Vehiculo(string Marca, int alineamiento, string Velocidad, string color, string Tipo, int Modelo) :
         base(Marca, alineamiento, Velocidad, color, Tipo, Modelo)
        { 
        }
    }
}
