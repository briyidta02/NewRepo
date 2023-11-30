using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.Data
{
    public static class RevisionDataManager
    {
        public static void SaveRevision(Revision revisiones)
        {
            Console.WriteLine(revisiones);
        }
        private const string DATA_FILE = "C:\\Users\\USUARIO\\Source\\Repos\\briyidta02\\NewRepo\\ConsoleApp2\\Data\\Revision.json";

        public static Revision AddRevision(Revision revisiones)
        {
            try
            {
                string currentRevisionState = GetFileInfo();
                var jObject = JObject.Parse(currentRevisionState);
                revisiones.Id = $"{jObject.Properties().Count() + 1}";
                string RevisionJson = JsonConvert.SerializeObject(revisiones);
                jObject.Add(revisiones.Id, RevisionJson);

                string outoutJson = JsonConvert.SerializeObject(jObject, Formatting.Indented);
                WriteFileInfo(outoutJson);
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);
                Console.ForegroundColor = ConsoleColor.Green;


            }

            return revisiones;
        }

            private static string GetFileInfo()
            {

                return File.ReadAllText(DATA_FILE);
            }
            private static void WriteFileInfo(string json)
            {
                File.WriteAllText(DATA_FILE, json);
            }

        internal static void SaveRevision()
        {
            throw new NotImplementedException();
        }
    }
}
