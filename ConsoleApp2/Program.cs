namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehiculo vehiculo = new Vehiculo("BMW", 0, "media", "Rojo", "Deportivo", 2018);
            Console.WriteLine("la marca del carro es:" + vehiculo.Marca);
            Console.WriteLine("Su alineacion es :"+vehiculo.alineamiento);
            Console.WriteLine("Su nivel de velozidad es: " + vehiculo.Velocidad);
            Console.WriteLine("el color es: " + vehiculo.color);
            Console.WriteLine("El tipo de carro es:" + vehiculo.Tipo);
            Console.WriteLine("el modelo del carro es del ano: " + vehiculo.Modelo);
        }
    }
}