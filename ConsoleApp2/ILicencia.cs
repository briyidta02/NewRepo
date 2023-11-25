using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface ILicencia
    {
        Licencia Renovacion (Licencia licencia);

        List<Licencia> Search(DateTime FechaVigencia, DateTime FechaExpediente);


    }
}
