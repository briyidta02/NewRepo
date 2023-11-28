using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public class RecorridosDataManager
    {
        public static void SaveRecorridos (Recorridos recorridos)
        {
            Console.WriteLine(recorridos);
        }
        private const string DATA_FILE = "C:\\Users\\Tatiana\\Source\\Repos\\briyidta02\\NewRepo\\ConsoleApp2\\Data\\Recorridos.json";

        public static Recorridos AddRecorridos(Recorridos recorridos) 
        {
            try
            {
                string currentRecorridosState = GetFileInfo();
                var jObject = JObject.Parse(currentRecorridosState);
                recorridos.Id = $"{jObject.Properties().Count() + 1}";
                string RecorridosJson = JsonConvert.SerializeObject(recorridos);
                jObject.Add(recorridos.Id, RecorridosJson);

                string outoutJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outoutJson);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;

            }
            return recorridos;
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



