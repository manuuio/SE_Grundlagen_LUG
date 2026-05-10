using System.Globalization;
using System.Text.RegularExpressions;

namespace _09_Brauerei
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Request melon price and quantity; generate a formatted console receipt. Supports locale testing.
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            int kundeKaesten = anzahlKaesten();
            double kundePreisProKasten = preisEingabe();

            double zwischensumme = Berechnung(kundeKaesten, kundePreisProKasten);
            double prozentRabatt = prozentBerechnung(kundeKaesten);


            Quittung(kundeKaesten, kundePreisProKasten, zwischensumme, prozentRabatt);
        }

        static int anzahlKaesten()
        {
            bool kaestenCheck;
            int kaesten;


            

            do
            {
                Console.Write($"Bitte geben Sie die Anzahl der Kästen ein: ");
                kaestenCheck = int.TryParse(Console.ReadLine(), out kaesten);

                if (!kaestenCheck)
                    Console.WriteLine("Bitte nur Ziffern eigeben");
            }
            while (!kaestenCheck);
            Console.Clear();

            return kaesten;
        }

        static double preisEingabe()
        {
            bool preisCheck;
            int preis;



            do
            {
                Console.Write($"Bitte geben Sie die den Preis pro Kasten ein: ");
                preisCheck = int.TryParse(Console.ReadLine(), out preis);

                if (!preisCheck)
                    Console.WriteLine("Bitte nur Ziffern eigeben");
            }
            while (!preisCheck);
            Console.Clear();

            return preis;
        }

        static double Berechnung(int anzahlKaesten, double Preis)
        {
            return anzahlKaesten * Preis;
        }

        static double prozentBerechnung(int anzahlKaesten)
        {
            double prozentRabatt;

            if (anzahlKaesten >= 10)
                prozentRabatt = 0.05;
            else if (anzahlKaesten >= 50)
                prozentRabatt = 0.07;
            else if (anzahlKaesten >= 100)
                prozentRabatt = 0.10;
            else
                prozentRabatt = 0.00;

            return prozentRabatt;
        }


        static void Quittung(int anzahlKasten, double costProKasten, double zwischensumme, double discountPercentage)
        {

            const double MwSt = 0.19;
            const double MwStRechnung = 1.19;
            double nurRabatt = zwischensumme * discountPercentage;
            double endpreis = (zwischensumme - nurRabatt) * MwStRechnung;
            double nurMwSt = (zwischensumme - nurRabatt) * MwSt;

            Console.WriteLine(new string('-', 39));
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("🍺  Brauereibetrieb Blackwing Lair  🍺");
            Console.ResetColor();
            Console.WriteLine(new string('-', 39));
            Console.WriteLine("Anzahl Melonen:        " + $"{anzahlKasten,10} Stück");
            Console.WriteLine("Einzelpreis:       " + $"{costProKasten,20:c}");
            Console.WriteLine(new string('-', 39));
            Console.WriteLine("Zwischensumme:     " + $"{zwischensumme,20:c}");
            Console.WriteLine(new string('-', 39));
            Console.WriteLine("Rabattstufe:     " + $"{discountPercentage * 100,20:f0} %");
            Console.WriteLine("Preisänderung:     " + $"{nurRabatt,20:c}");
            Console.WriteLine(new string('-', 39));
            Console.WriteLine("\u001b[1mEndpreis:          " + $"{endpreis,20:c}\u001b[0m");
            Console.WriteLine($"inkl. {MwSt * 100:f0} % MwSt.   " + $"{nurMwSt,20:c}");
            Console.WriteLine(new string('-', 39));
        }
    }
}
