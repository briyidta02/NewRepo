using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public static class  VehiculoAutomotorDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Tatiana\\Source\\Repos\\briyidta02\\NewRepo\\ConsoleApp2\\Data\\VehiculoAutomotor";
        public static VehiculoAutomotor AddVehiculoAutomotor(VehiculoAutomotor vehiculoautomotor)
        {
            try
            {
                string currentVehiculoAutomotorState = GetFileInfo();
                var jObject = JObject.Parse(currentVehiculoAutomotorState);
                vehiculoautomotor.Id = $"{jObject.Properties().Count () + 1}";
                string VehiculoAutomotorJson = JsonConvert.SerializeObject(vehiculoautomotor);
                jObject.Add(vehiculoautomotor.Id, VehiculoAutomotorJson);

                string outoutJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outoutJson);
            }
            catch (Exception ex) 
            {

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;

            }


            return vehiculoautomotor;
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
