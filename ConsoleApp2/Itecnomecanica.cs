using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface Itecnomecanica
    {
        Mantenimiento NotificacionRenovacion (Mantenimiento mantenimiento);

        List<Mantenimiento> Search(DateTime FechaInicio, DateTime FechaFinal);
    }
}
