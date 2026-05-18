namespace _05AufgabeRechnerOOP;

internal class RechnerProgram
{
    static void Main(string[] args)
    {

        List<Rechner> rechnungsverlauf = new List<Rechner>();



        while (true)
        {
            //Instanzierung der Klasse Rechner
            Rechner rechner = new Rechner();
            double operand1 = double.Parse(Frage("Geben Sie den ersten Operanden ein"));
            double operand2 = double.Parse(Frage("Geben Sie den zweiten Operanden ein"));
            string @operator = Frage("Geben Sie den Operator ein (+, -, *, /)");
            rechner.SetOperator(@operator);
            rechner.SetOperand1(operand1);
            rechner.SetOperand2(operand2);
            rechner.Berechnen();
            rechner.GibAusgabe();

            //Hinzufügen der Instanz zur Liste
            rechnungsverlauf.Add(rechner);
            //was geschieht dann Nächstes?
            string antwort = Frage("E(x)it oder (N)ochmal oder (V)erlauf anzeigen? (x/n/v)");

            switch (antwort.ToLower())
            {
                case "x":
                    return; //programm beenden
                case "n":
                    break;
                case "v":
                    ZeigeVerlauf(rechnungsverlauf);
                    break;
                default:
                    Console.WriteLine("Ungültiges Zeichen...");
                    break;
            }
        }
    }

    private static void ZeigeVerlauf(List<Rechner> verlauf)
    {
        Console.WriteLine("Verlauf:");
        foreach (var rechner in verlauf)
        {
            Console.Write("\t");
            rechner.GibAusgabe();
        }
    }

    static string Frage(string prompt)
    {
        Console.Write(prompt + ": ");
        return Console.ReadLine();
    }
}
