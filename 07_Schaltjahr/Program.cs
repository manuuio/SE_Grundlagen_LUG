namespace _07_Schaltjahr
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Weil die astronomische Dauer eines Jahres (wenn die Erde die Sonne einmal umrundet
            hat) etwas länger ist als 365 Tage, wurden Schaltjahre zum Ausgleich eingeführt.

            Ein Schaltjahr ist ein Jahr, welches eine Jahreszahl hat, die durch 4 teilbar ist.
            Jahreszahlen, die durch 100 teilbar sind, sind allerdings keine Schaltjahre. Es sei denn,
            die Jahreszahl ist durch 400 teilbar.

            Erstellen Sie ein Programm, welches prüft, ob eine eingegebene
            Jahresziffer ein Schaltjahr ist oder nicht und anschließend eine entsprechende Antwort
            ausgibt.

            Schritte:
            ---------
            - Variablen deklarieren (optional)
            - User-Eingabe der Jahreszahl
            - Berechnung ob Schaltjahr
            - Ausgabe der Antwort
            */

            while (true)
            {
                Console.WriteLine("Bitte geben Sie eine Jahreszahl ein:");
                bool gültig = int.TryParse(Console.ReadLine(), out int jahr);

                if (!gültig || jahr < 1 || jahr > 4444)
                {
                    Console.WriteLine("Ungültige Eingabe! Bitte eine gültige Jahreszahl eingeben.");
                    continue;
                }
                Console.WriteLine();

                bool istSchaltjahr = (jahr % 4 == 0 && jahr % 100 != 0) || (jahr % 400 == 0);

                if(istSchaltjahr)
                    Console.WriteLine($"{jahr} ist ein Schaltjahr!");
                else
                    Console.WriteLine($"{jahr} ist kein Schaltjahr!");

                break;
            }

            Console.WriteLine("Zum beenden eine beliebige Taste drücken");
            Console.ReadKey();

        }
    }
}
