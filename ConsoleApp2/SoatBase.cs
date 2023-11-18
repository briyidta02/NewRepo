namespace ConsoleApp2
{
    public class SoatBase
    {

        public Soat Notificacionsoat(Soat soat)
        {
            DateTime now = DateTime.Now;

            DateTime startDate = new DateTime(2021, 10, 21);

            DateTime endDate = new DateTime(2023, 10, 21);

            TimeSpan timeRemaining = endDate - now;

            int daysThreshold = 7;

            if (timeRemaining.TotalDays <= daysThreshold)
            {
                Console.WriteLine($"¡Atención! El SOAT está próximo a vencer en {timeRemaining.TotalDays} días.");
            }
            else
            {
                Console.WriteLine("El SOAT todavía está vigente.");
            }
        }
    }
}