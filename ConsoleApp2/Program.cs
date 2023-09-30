namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Vehiculo vehiculo = new Vehiculo("BMW", 0, "media", "Rojo", "Deportivo", 2018);
            Console.WriteLine(vehiculo.Marca);
        }
    }
}