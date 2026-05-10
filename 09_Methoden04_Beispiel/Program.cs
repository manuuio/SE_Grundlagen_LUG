namespace _09_Methoden04_Beispiel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string rechenzeichen;
            double zahl1, zahl2, ergebnis;

            rechenzeichen = Start();
            zahl1 = ZahlenEingabe("1");
            zahl2 = ZahlenEingabe("2");
            ergebnis = Berechnung(zahl1, zahl2, rechenzeichen);
            Ausgabe(ergebnis);
        }
        static void Ausgabe(double erg)
        {
            Console.Clear();
            Console.WriteLine($"Ihr Ergebnis ist: {erg}");
        }
        static void Division0()
        {
            Console.WriteLine("Eine Division durch 0 ist nicht möglich!");
            Console.WriteLine("Beenden mit beliebiger Taste...");
            Console.ReadKey();
            Environment.Exit(0);
        }
        static double Berechnung(double d1, double d2, string zeichen)
        {
            switch (zeichen)
            {
                case "1":
                    return d1 + d2;
                case "2":
                    return d1 - d2;
                case "3":
                    return d1 * d2;
                case "4":
                    if (d2 != 0)
                        return d1 / d2;
                    else
                        Division0();
                    break;
            }
            return 0;
        }
        static double ZahlenEingabe(string anzahl)
        {
            bool check;
            double zahl;

            Console.Clear();

            do
            {
                Console.Write($"Bitte geben Sie Ihre {anzahl}. Zahl ein: ");
                check = double.TryParse(Console.ReadLine(), out zahl);

                if (!check)
                    Console.WriteLine("Bitte nur Ziffern eigeben");
            }
            while (!check);

            return zahl;
        }
        static string Start()
        {
            bool check;
            string eingabe;

            Console.WriteLine("Willkommen zum Taschenrechner!");
            Console.WriteLine();
            Console.WriteLine("(1) Addition");
            Console.WriteLine("(2) Subtraktion");
            Console.WriteLine("(3) Multiplikation");
            Console.WriteLine("(4) Division");
            Console.WriteLine();
            do
            {
                check = false;
                Console.Write("Bitte treffen Sie Ihre Auswahl: ");
                eingabe = Console.ReadLine();

                if (eingabe == "1" || eingabe == "2" || eingabe == "3" || eingabe == "4")
                    check = true;
                else
                    Console.WriteLine("Bitte nur 1-4 eingeben!");
            } while (!check);

            return eingabe;
        }
    }
}
