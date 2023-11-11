using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{

    public class Vehiculo: VehiculoAutomotor ,IRegistro
    {
        public Vehiculo(string Marca, int alineamiento, string Velocidad, string color, string Tipo, int Modelo) :
         base(Marca, alineamiento, Velocidad, color, Tipo, Modelo)
        { 
            
        }

        public string EstablecerFechasMantenimiento(VehiculoAutomotor vehiculoAutomotor)
        {
            throw new NotImplementedException();
        }

        public string GenerarFechasMantenimiento(VehiculoAutomotor vehiculoAutomotor)
        {
            throw new NotImplementedException();
        }

        public VehiculoAutomotor RegistroVehiculo(VehiculoAutomotor vehiculoAutomotor)
        {
            throw new NotImplementedException();
        }

        public List<VehiculoAutomotor> Search(string Marca, int alineamiento, string Velocidad, string color, string Tipo, int Modelo)
        {
            throw new NotImplementedException();
        }
    }
    
       
}

