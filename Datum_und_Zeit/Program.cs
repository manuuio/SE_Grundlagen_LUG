namespace Datum_und_Zeit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Datum & Uhrzeit
            DateTime dt1 = new DateTime(2020, 8, 17, 12, 15, 37);

            // Verschiedene Ausgabeformate
            Console.WriteLine(dt1);
            Console.WriteLine(dt1.ToLongDateString());
            Console.WriteLine(dt1.ToShortDateString());
            Console.WriteLine(dt1.ToLongTimeString());
            Console.WriteLine(dt1.ToShortTimeString());
            Console.WriteLine();

            // Nur Datum
            DateTime dt2 = new DateTime(1980, 11, 3);

            // Aktuelles Datum & Uhrzeit
            DateTime dt3 = DateTime.Now;
            Console.WriteLine(dt3);
            Console.WriteLine();

            // Wochentag-Abfrage
            DateTime dt4 = new DateTime(2026, 4, 29);

            if (dt4.DayOfWeek == DayOfWeek.Wednesday)
            {
                Console.WriteLine("War ein Mittwoch");
            }
            else
            {
                Console.WriteLine("War kein Mittwoch");
            }

        }
    }
}
