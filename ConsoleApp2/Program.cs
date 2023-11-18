using ConsoleApp2.Data;

namespace ConsoleApp2
{
    internal class Program
    {
        private static int opcion;

        static void Main(string[] args)
        {
            MENUPRINCIPAL();

            
            DateTime fechageneral = new DateTime(2023, 10, 21);

            Console.WriteLine("**INFORMACION VEHICULO**");
            VehiculoAutomotor vehiculoautomotor = new VehiculoAutomotor("BMW", 0, "media", "Rojo", "Deportivo", 2018);
            Console.WriteLine("la marca del carro es:" + vehiculoautomotor.Marca);
            Console.WriteLine("Su alineacion es :" + vehiculoautomotor.alineamiento);
            Console.WriteLine("Su nivel de velozidad es: " + vehiculoautomotor.Velocidad);
            Console.WriteLine("el color es: " + vehiculoautomotor.color);
            Console.WriteLine("El tipo de carro es:" + vehiculoautomotor.Tipo);
            Console.WriteLine("el modelo del carro es del ano es: " + vehiculoautomotor.Modelo);

            VehiculoAutomotorDataManager.AddVehiculoAutomotor(vehiculoautomotor);

            Console.WriteLine("**INFORMACION SOAT**");
            Soat SOAT = new Soat(198876, new DateTime(2021, 10, 21), new DateTime(2022, 10, 21));
            Console.WriteLine("El numero de soat es:" + SOAT.NumeroAseguradora);
            Console.WriteLine("la fecha proxima es:" + SOAT.FechaProxima);
            Console.WriteLine("La fecha final es de: " + SOAT.FechaFinal);

            SoatDataManager.AddSoat(SOAT);

            Console.WriteLine("**INFORMACION LICENCIA**");
            Licencia licencia = new Licencia(3525666, new DateTime(2024, 08, 02), new DateTime(2021, 08, 02), "Particular", "Antonella Ramirez");
            Console.WriteLine("Numero de licencia es:" + licencia.IdentificacionPersona);
            Console.WriteLine("Fehca de vigencia es: " + licencia.FechaVigencia);
            Console.WriteLine("Fecha de expediente: " + licencia.FechaExpediente);
            Console.WriteLine("Servicio:" + licencia.Servicio);
            Console.WriteLine("Nombre de conductor: " + licencia.NombreConductor);

            LicenciaDataManager.AddLicencia(licencia);

            Console.WriteLine("**INFORMACION CONDUCTOR**");
            Conductor conductor = new Conductor("Antonella Ramirez", 315 - 202 - 3879, "calle 54 G N 23 - 25", 1019958263);
            Console.WriteLine("Nombre de conductor:" + conductor.Nombre);
            Console.WriteLine("Telefono del conductor: " + conductor.Telefono);
            Console.WriteLine("Direccion del conductor:" + conductor.Direccion);
            Console.WriteLine("Numero de identificacion:" + conductor.Identificacion);

            ConductorDataManager.AddConductor(conductor);

            Console.WriteLine("**INFORMACION MANTENIMIENTO**");
            Mantenimiento Mantenimiento = new Mantenimiento(new DateTime(2022, 06, 02), "Formula 1", "mantenimiento general", 160648, 02 - 12 - 2022, 105.000, 0.5, "MECATRONIX", "Richar Monsalve", "Equilibrados");
            Console.WriteLine("Fecha de inicio de mantenimiento:" + Mantenimiento.FechaInicio);
            Console.WriteLine("Marca de aceite: " + Mantenimiento.MarcaAceite);
            Console.WriteLine("Servicio de mantenimiento:" + Mantenimiento.Servicio);
            Console.WriteLine("Kilometraje : " + Mantenimiento.Kilometraje);
            Console.WriteLine("Proximo mantenimiento :" + Mantenimiento.ProximoCambio);
            Console.WriteLine("Costo de mantenimiento: " + Mantenimiento.Costo);
            Console.WriteLine("Liniamiento:" + Mantenimiento.Lineamiento);
            Console.WriteLine("Nombre de taller: " + Mantenimiento.NombreTaller);
            Console.WriteLine("Nombre de mecanico:" + Mantenimiento.NombreMecanico);
            Console.WriteLine(" Estado de frenos" + Mantenimiento.Frenos);

            MantenimientoDataManager.AddMantenimiento(Mantenimiento);
            

        }

        public static void MENUPRINCIPAL()
        {
            Console.WriteLine("MENÚ");
            Console.WriteLine("1. Informacion del vehiculo");
            Console.WriteLine("2. Informacion Soat");
            Console.WriteLine("3. Informacion licencia");
            Console.WriteLine("4. Informacion conductor");
            Console.WriteLine("5. Informacion mantenimiento");

            Console.Write("Ingrese un número entero: ");
            string userInput = Console.ReadLine();

            opcion = int.Parse(userInput);

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Seleccionaste la opcion 1");
                    INFORMACIONVEHICULO();
                    break;
                case 2:
                    Console.WriteLine("Seleccionaste la opcion 2");
                    Console.WriteLine();
                    INFORMACIONSOAT();
                    break;
                case 3:
                    Console.WriteLine("Seleccionaste la opcion 3");
                    Console.WriteLine();
                    INFORMACIONLICENCIA();
                    break;
                case 4:
                    Console.WriteLine("Seleccionaste la opcion 4");
                    Console.WriteLine();
                    INFORMACIONCONDUCTOR();
                    break;
                case 5:
                    Console.WriteLine("Seleccionaste la opcion 5");
                    Console.WriteLine();
                    INFORMACIONMANTENIMIENTO();
                    break;
                   
            }
            MENUPRINCIPAL();
        }
        public static void INFORMACIONVEHICULO()
        {
            Console.WriteLine("*INFORMACION VEHICULO*");
            VehiculoAutomotor vehiculoautomotor = new VehiculoAutomotor("BMW", 0, "media", "Rojo", "Deportivo", 2018);
            Console.WriteLine("la marca del carro es:" + vehiculoautomotor.Marca);
            Console.WriteLine("Su alineacion es :" + vehiculoautomotor.alineamiento);
            Console.WriteLine("Su nivel de velozidad es: " + vehiculoautomotor.Velocidad);
            Console.WriteLine("el color es: " + vehiculoautomotor.color);
            Console.WriteLine("El tipo de carro es:" + vehiculoautomotor.Tipo);
            Console.WriteLine("el modelo del carro es del ano es: " + vehiculoautomotor.Modelo);

        }
        public static void INFORMACIONSOAT()
        {
            Console.WriteLine("*INFORMACION SOAT*");
            Soat SOAT = new Soat(198876, new DateTime(2021, 10, 21), new DateTime(2022, 10, 21));
            Console.WriteLine("El numero de soat es:" + SOAT.NumeroAseguradora);
            Console.WriteLine("la fecha proxima es:" + SOAT.FechaProxima);
            Console.WriteLine("La fecha final es de: " + SOAT.FechaFinal);
        }
        public static void INFORMACIONLICENCIA()
        {
            Console.WriteLine("*INFORMACION LICENCIA*");
            Licencia licencia = new Licencia(3525666, new DateTime(2024, 08, 02), new DateTime(2021, 08, 02), "Particular", "Antonella Ramirez");
            Console.WriteLine("Numero de licencia es:" + licencia.IdentificacionPersona);
            Console.WriteLine("Fehca de vigencia es: " + licencia.FechaVigencia);
            Console.WriteLine("Fecha de expediente: " + licencia.FechaExpediente);
            Console.WriteLine("Servicio:" + licencia.Servicio);
            Console.WriteLine("Nombre de conductor: " + licencia.NombreConductor);
        }
        public static void INFORMACIONCONDUCTOR()
        {
            Console.WriteLine("*INFORMACION CONDUCTOR*");
            Conductor conductor = new Conductor("Antonella Ramirez", 315 - 202 - 3879, "calle 54 G N 23 - 25", 1019958263);
            Console.WriteLine("Nombre de conductor:" + conductor.Nombre);
            Console.WriteLine("Telefono del conductor: " + conductor.Telefono);
            Console.WriteLine("Direccion del conductor:" + conductor.Direccion);
            Console.WriteLine("Numero de identificacion:" + conductor.Identificacion);
        }
        public static void INFORMACIONMANTENIMIENTO()
        {

            Console.WriteLine("*INFORMACION MANTENIMIENTO*");
            Mantenimiento Mantenimiento = new Mantenimiento(new DateTime(2022, 06, 02), "Formula 1","2 LITROS", "mantenimiento general", 160648, 02 - 12 - 2022, 105.000, 0.5, "MECATRONIX", "Richar Monsalve", "Equilibrados");
            Console.WriteLine("Fecha de inicio de mantenimiento:" + Mantenimiento.FechaInicio);
            Console.WriteLine("Marca de aceite: " + Mantenimiento.MarcaAceite);
            Console.WriteLine("Servicio de mantenimiento:" + Mantenimiento.Servicio);
            Console.WriteLine("Kilometraje : " + Mantenimiento.Kilometraje);
            Console.WriteLine("Proximo mantenimiento :" + Mantenimiento.ProximoCambio);
            Console.WriteLine("Costo de mantenimiento: " + Mantenimiento.Costo);
            Console.WriteLine("Liniamiento:" + Mantenimiento.Lineamiento);
            Console.WriteLine("Nombre de taller: " + Mantenimiento.NombreTaller);
            Console.WriteLine("Nombre de mecanico:" + Mantenimiento.NombreMecanico);
            Console.WriteLine(" Estado de frenos" + Mantenimiento.Frenos);
        }
    }

}

    

