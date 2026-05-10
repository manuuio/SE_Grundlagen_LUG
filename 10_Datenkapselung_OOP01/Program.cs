namespace _01Datenkapselung;

class Program
{
    static void Main(string[] args)
    {
        //SampleBestellungen();
        Bestellung[] bestellVerlauf = new Bestellung[3];
        int index = 0;
        while (true)
        {
            Console.WriteLine("1) Neue Bestellung aufnehmen");
            Console.WriteLine("2) Letzte 3 Bestellungen anzeigen");
            Console.WriteLine("3) Beenden");
            Console.WriteLine("\tIhre Wahl:");
            string wahl = Console.ReadLine();
            switch (wahl)
            {
                case "1":
                    Bestellung neu = BestellungAufnehmen();
                    bestellVerlauf[index % 3] = neu;
                    index++;
                    Console.Clear();
                    break;
                case "2":
                    Console.Clear();
                    BestellungAnzeigen(bestellVerlauf);
                    break;
                case "3":
                    Console.WriteLine("Programm wird beendet");
                    return; // Beendet die Main-Methode und somit das Programm
                default:
                    Console.Clear();
                    Console.WriteLine("Ungültige Eingabe");
                    break;
            }

        }
    }

    private static void BestellungAnzeigen(Bestellung[] orders)
    {
        Console.WriteLine("letzte 3 Bestellungen");
        for (int i = 0; i < orders.Length; i++)
        {
            if (orders[i] != null) // Überprüfen, ob die Bestellung existiert
            {
                orders[i].BestellInfoAnzeigen();
            }
        }
    }

    private static Bestellung BestellungAufnehmen()
    {
        Console.WriteLine("Artikel:");
        string artikel = Console.ReadLine();
        Console.WriteLine("Menge:");
        int menge = int.Parse(Console.ReadLine());
        Console.WriteLine("Preis: ");
        double preis = double.Parse(Console.ReadLine());
        Bestellung neu = new Bestellung(artikel, menge, preis, DateTime.Now);
        return neu;
    }

    private static void SampleBestellungen()
    {
        //Bestellung1 
        Bestellung bestellung1 = new Bestellung("Buch", 2, 10.0, DateTime.Now.AddDays(-1));
        //bestellung1.SetArtikel("Buch");
        //bestellung1.SetMenge(2);
        bestellung1.BestellInfoAnzeigen();

        //Bestellung2
        Bestellung bestellung2 = new Bestellung();
        bestellung2.SetArtikel("Laptop");
        bestellung2.BestellInfoAnzeigen();
    }
}
