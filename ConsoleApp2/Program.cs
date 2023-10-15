﻿namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**INFORMACION VEHICULO**");
            Vehiculo vehiculo = new Vehiculo("BMW", 0, "media", "Rojo", "Deportivo", 2018);
            Console.WriteLine("la marca del carro es:" + vehiculo.Marca);
            Console.WriteLine("Su alineacion es :" + vehiculo.alineamiento);
            Console.WriteLine("Su nivel de velozidad es: " + vehiculo.Velocidad);
            Console.WriteLine("el color es: " + vehiculo.color);
            Console.WriteLine("El tipo de carro es:" + vehiculo.Tipo);
            Console.WriteLine("el modelo del carro es del ano es: " + vehiculo.Modelo);

            Console.WriteLine("**INFORMACION SOAT**");
            Soat SOAT = new Soat(198876, "09-05-2021", "09-05-2022");
            Console.WriteLine("El numero de soat es:" + SOAT.NumeroSoat);
            Console.WriteLine("la fecha proxima es:" + SOAT.FechaProxima);
            Console.WriteLine("La fecha final es de: " + SOAT.FechaFinal);

            Console.WriteLine("**INFORMACION LICENCIA**");
            Licencia licencia = new Licencia(3525666, "02-08-2024", "02-08-2021", "Particular", "Antonella Ramirez");
            Console.WriteLine("Numero de licencia es:" + licencia.IdentificacionPersona);
            Console.WriteLine("Fehca de vigencia es: " + licencia.FechaVigencia);
            Console.WriteLine("Fecha de expediente: " + licencia.FechaExpediente);
            Console.WriteLine("Servicio:" + licencia.Servicio);
            Console.WriteLine("Nombre de conductor: " + licencia.NombreConductor);

            Console.WriteLine("**INFORMACION CONDUCTOR**");
            Conductor conductor = new Conductor("Antonella Ramirez",315-202-3879,"calle 54 G N 23 - 25", 1019958263);
            Console.WriteLine("Nombre de conductor:" + conductor.Nombre);
            Console.WriteLine("Telefono del conductor: " + conductor.Telefono);
            Console.WriteLine("Direccion del conductor:" + conductor.Direccion);
            Console.WriteLine("Numero de identificacion:" + conductor.Identificacion);

        }
    }
}