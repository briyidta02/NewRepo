using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public static class ConductorDataManager
    {
        public static void SaveConductor(Conductor conductor)
        {
            Console.WriteLine(conductor);
        }


        private const string DATA_FILE = "C:\\Users\\Tatiana\\Source\\Repos\\briyidta02\\NewRepo\\ConsoleApp2\\Data\\Conductor.json";
        public static Conductor AddConductor(Conductor conductor)
        {
            try
            {
                string currentConductorState = GetFileInfo();
                var jObject = JObject.Parse(currentConductorState);
                conductor.Id = $"{jObject.Properties().Count() +1}";
                string ConductorJson = JsonConvert.SerializeObject(conductor);
                jObject.Add(conductor.Id, ConductorJson);
                
                string outoutJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outoutJson);
            }
            catch (Exception ex) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            
            
            }

            return conductor;
        }
        private static string GetFileInfo()
        {

            return File.ReadAllText(DATA_FILE);
        }
        private static void WriteFileInfo(string json)
        {
            File.WriteAllText(DATA_FILE, json);
        }
    }
}
