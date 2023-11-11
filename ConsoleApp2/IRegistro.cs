using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface IRegistro
    {
        VehiculoAutomotor RegistroVehiculo(VehiculoAutomotor vehiculoAutomotor);

        string GenerarFechasMantenimiento(VehiculoAutomotor vehiculoAutomotor);

        List<VehiculoAutomotor> Search(string Marca, int alineamiento, string Velocidad, string color, string Tipo, int Modelo); 
    }
}
