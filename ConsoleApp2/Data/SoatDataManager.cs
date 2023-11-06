using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public static class SoatDataManager
    {
        private const string DATA_FILE = "C:\\Users\\Tatiana\\Source\\Repos\\briyidta02\\NewRepo\\ConsoleApp2\\Data\\Soat.json";

        public static Soat AddSoat(Soat soat)
        {
            try
            {
                string currentSoatState = GetFileInfo();
                var jObject = JObject.Parse (currentSoatState);
                soat.Id = $"{jObject.Properties(). Count () + 1}";
                string SoatJson = JsonConvert.SerializeObject(soat);
                jObject.Add(soat.Id, SoatJson);

                string outoutJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outoutJson);
            }
            catch (Exception ex)  
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;
            }
            return soat;
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
