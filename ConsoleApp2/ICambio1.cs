using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ICambio1
    {
        Mantenimiento RegistrarCambios(Mantenimiento vehiculoAutomotor);

        string TiposdeCambios (Mantenimiento vehiculoAutomotor);

        string FechaProximomantenimiento (Mantenimiento vehiculoAutomotor);

        List<Mantenimiento> Search(string MarcaAceite, string Servicio, double Kilometraje, double Costo, double Lineamiento, string NombreTaller, string NombreMecanico, string Frenos);
    }
}

    
