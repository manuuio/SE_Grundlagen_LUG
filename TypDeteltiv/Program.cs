//Schreibe ein C#-Programm, das den Benutzer nach einer beliebigen Texteingabe fragt und dann selbst herausfindet, welcher Datentyp am besten zu dieser Eingabe passt.
//Das Programm soll dabei jeden sinnvollen Datentyp prüfen und den kleinstmöglichen passenden auswählen. Welche Typen du prüfst und in welcher Reihenfolge, ist Teil der Aufgabe — überlege dir das sorgfältig, denn die Reihenfolge hat Auswirkungen auf das Ergebnis.
//Wenn die Eingabe zu mehreren Typen passen könnte, soll das Programm dem Benutzer alle Möglichkeiten anzeigen und ihn selbst wählen lassen.
//Am Ende gibt das Programm aus, welcher Typ gewählt wurde und welchen Wert die Variable enthält.

//1. Eingabe des Benutzers
Console.WriteLine("Hallo User bitte mache eine Eingabe:");
var eingabe = Console.ReadLine();

//2. Abfangen eines möglichen null Werts
if (eingabe == null || eingabe.Length == 0) {
    Console.WriteLine("Die Eingabe war ungültig.");
    return; //return beendet das Programm bzw. die Main Methode.
}

//3.
// Prüfung nach länge der Eingabe
if(eingabe.Length == 1)
{

    char zeichenEingabe = Convert.ToChar(eingabe);
    if (char.IsDigit(zeichenEingabe)){
        byte kleineZahl = byte.Parse(eingabe);
        Console.WriteLine($"Die Eingabe passt am besten zum Datentyp byte mit dem Wert {kleineZahl}");
    }
    else
    {
        Console.WriteLine($"Die Eingabe passt am besten zum Datentyp char mit dem Wert '{zeichenEingabe}'");
    }

}
else
{
    if(eingabe == "true" || eingabe == "false" || eingabe == "True" || eingabe == "False")
    {
        Console.WriteLine($"{eingabe} kann ein bool aber ein string sein. Drücke 1 für bool und 2 für string:");
        Console.WriteLine("1. bool");
        Console.WriteLine("2. string");
        var auswahl = Console.ReadKey();
        if (auswahl.KeyChar == '1')
        {
            bool boolEingabe = bool.Parse(eingabe);
            Console.WriteLine($"\nDie Eingabe {boolEingabe} passt am besten zm Datentyp bool");
        }
        else if (auswahl.KeyChar == '2')
        {
            Console.WriteLine($"\nDie eingabe {eingabe} ist vom Datentyp string!");
        }
        else
        {
            Console.WriteLine("\nUngültige Auswahl.");
        }

    }
    else if(double.TryParse(eingabe, out double eingabeZahl))
    {

        //1. Prüfung auf integer (wenn die Zahl keine Nachkommastellen hat und im Bereich von int liegt)
        //Wenn Ganzzahl -> prüfen auf byte int16 int32 int64 int128 und bigint
        if (eingabeZahl % 1 == 0)
        {
            if (eingabeZahl <= 255 && eingabeZahl >= 0)
            {
                byte byteEingabe = byte.Parse(eingabe);
                Console.WriteLine($"Die Eingabe passt am besten zum Datentyp byte mit dem Wert {byteEingabe}");
            }
            else if (eingabeZahl <= Int16.MaxValue && eingabeZahl >= Int16.MinValue)
            {
                Int16 int16Eingabe = Int16.Parse(eingabe);
                Console.WriteLine("Die Eingabe passt am besten zum Datentyp Int16 mit dem Wert " + int16Eingabe);
            }
            else if (eingabeZahl <= int.MaxValue && eingabeZahl >= int.MinValue)
            {
                int int32Eingabe = int.Parse(eingabe);
                Console.WriteLine("Die Eingabe passt am besten zum Datentyp Int32 mit dem Wert " + int32Eingabe);
            }
            else if (eingabeZahl <= long.MaxValue && eingabeZahl >= long.MinValue)
            {
                long int64Eingabe = long.Parse(eingabe);
                Console.WriteLine("Die Eingabe passt am besten zum Datentyp Int64 mit dem Wert " + int64Eingabe);
            }
            else if (Int128.TryParse(eingabe, out Int128 int128Eingabe)) { 

                Console.WriteLine("Die Eingabe passt am besten zum Datentyp Int128 mit dem Wert " + int128Eingabe);
            }
            else
            {
                Console.WriteLine("Die Zahl ist zu groß, wir nutzen hier string als Datentyp");
            }

        }
        else if (double.TryParse(eingabe, out double doubleEingabe))
        {
            Console.WriteLine($"Die Eingabe {doubleEingabe} passt am besten zu einem double");
        }
        //2. Prüfung auf double (wenn die Zahl Nachkommastellen hat oder außerhalb des Bereichs von int liegt)
    }
    else
    {
        //1. Prüfung auf string (da die Eingabe weder eine Zahl noch ein boolescher Wert ist)
        Console.WriteLine($"\nDie eingabe {eingabe} ist vom Datentyp string!");
    }
}



