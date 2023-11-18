using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ISoat
    {
        Soat Notificacionsoat(Soat soat);
        string FechaProximavencer (Soat soat);

        List<Soat> Search(DateTime FechaProxima, DateTime FechaFinal);


    }
}
