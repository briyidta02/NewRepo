using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public static class MantenimientoDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Tatiana\\Source\\Repos\\briyidta02\\NewRepo\\ConsoleApp2\\Data\\Mantenimiento.json";
        public static Mantenimiento AddMantenimiento(Mantenimiento mantenimiento)
        {
            try
            {
                string currentMantenimientoState = GetFileInfo();
                var jObject = JObject.Parse(currentMantenimientoState);
                mantenimiento.Id = $"{jObject.Properties().Count() + 1}";
                string MantenimientoJson = JsonConvert.SerializeObject(mantenimiento);
                jObject.Add(mantenimiento.Id, MantenimientoJson);

                string outoutJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outoutJson);
            }

            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            return mantenimiento;
        }
        private static string GetFileInfo()
        {
            return File.ReadAllText(DATA_FILE);
        }
        private static void WriteFileInfo (string json)
        {
            File.WriteAllText(DATA_FILE, json); 
        }
    }
}
