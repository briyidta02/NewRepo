using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class HojadeVida
    {
       
        public class Hojadevida
        {
            private string mantenimiento { get; set; }

        }
        private static int opcion;
        static void Main(string[] args)
        {
            MostrarMenu();
        }

        public static void MostrarMenu()
        {

            Console.WriteLine("MENÚ");
            Console.WriteLine("1. RegistrarRevision");
            Console.WriteLine("2. MostrarRevisiones Programadas");
            Console.WriteLine("3. EMPEZAR DE NUEVO");

            while (true)
            {
                MostrarMenu();
                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarRevision();
                        break;
                    case "2":
                        MostrarRevisionesProgramadas();
                        break;
                    case "4":
                        return;

                }

            }
        }
                public static void RegistrarRevision()
                {
                    Console.Write("Ingrese la descripción de la revisión: ");
                    string descripcion = Console.ReadLine();

                    Console.Write("Ingrese la fecha de la revisión (YYYY-MM-DD): ");
                    DateTime fecha = DateTime.Parse(Console.ReadLine());

                    Revision nuevaRevision = new Revision(descripcion, fecha);
                    revisiones.Add(nuevaRevision);

                    Console.WriteLine("Revisión registrada con éxito.");
                }

                public static void MostrarRevisionesProgramadas()
                {
                    Console.WriteLine("Revisiones programadas:");
                    foreach (var revision in revisiones)
                    {
                        Console.WriteLine($"{revision.Descripcion} - {revision.Fecha}");
                    }
                }
            }
        }

    } }
