using ConsoleApp2.Logs;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public static class LicenciaDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Tatiana\\Source\\Repos\\briyidta02\\NewRepo\\ConsoleApp2\\Data\\Licencia.json";

        public static Licencia AddLicencia ( Licencia licencia )    

        {
            try {

                string currentLicenciaState = GetFileInfo();
                var jObject = JObject.Parse(currentLicenciaState);
                licencia.Id = $"{jObject.Properties().Count () + 1}";
                string LicenciaJson = JsonConvert.SerializeObject(licencia);
                jObject.Add(licencia.Id, LicenciaJson);

                string outoutJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outoutJson);

            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;

            }
            return licencia;
        }

        public static Licencia UpdateLicencia(Licencia licencia)
        {
            try 
            { 
            }
            catch (Exception ex)
            {
                Logger.LogError(ex);
            }
        }
        private static string GetFileInfo()
        {
            return File.ReadAllText(DATA_FILE);
        }
        private static  void WriteFileInfo (string json)
        {
            File.WriteAllText(DATA_FILE, json);
        }

    }
}
