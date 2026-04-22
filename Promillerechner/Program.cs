//Der User soll angeben können, wieviel Bier in Litern getrunken wurde.
//Daraus wird die Menge des Reinalkohols in Gramm berechnet.
//Getrunkene Menge in Milliliter * Alkoholgehalt * Dichte des Ethanols.
//Bei Bier also: Getrunkene Menge in Milliliter * 0.05 * 0.8
//Der User soll auch sein Gewicht in Kilogramm angeben.
//Dann wird der Blutalkoholgehalt in Promille berechnet.
//c = A / (0.65*G)
//c ist der Promillewert, A der aufgenommene Alkohol in Gramm und G das Körpergewicht in kg.
//Es soll dann eine Ausgabe, abhängig vom Promillewert folgen:
//bis 0.3: "Noch akzeptabel. Dennoch vorsichtig sein!"
//bis 0.5: "Achtung! Hände weg vom Steuer!"
//bis 0.8: "Das ist jetzt schon ganz schön ordentlich."
//ab 0.8: "Kein Kommentar..."
//Wählen Sie passende Datentypen für die jeweils notwendigen Variablen.

//Eingabe User Bier in Litern
Console.WriteLine("Hey User, wie viel bier hast du getrunken in Litern?");
double getrungkeneMenge;
double Reinalkohol = 0; //Deklaration der Variable Reinalkohol, damit sie auch außerhalb des if-Blocks zugänglich ist.
double gewicht = 0; //Deklaration der Variable Gewicht, damit sie auch außerhalb des if-Blocks zugänglich ist.
bool eingabeKorrekt = double.TryParse(Console.ReadLine(), out getrungkeneMenge);

if(eingabeKorrekt) Console.WriteLine("Der User hat "+ getrungkeneMenge + " Liter getrunken");
else Console.WriteLine("Die Eingabe war ungültig.");

//Berechnung des Reinalkohols in Gramm und Eingabe Gewicht
if (eingabeKorrekt)
{
    Reinalkohol = getrungkeneMenge * 1000 * 0.05 * 0.8; // Umrechnung von Litern in Milliliter und Berechnung des Reinalkohols in Gramm

    Console.WriteLine("User gebe dein gewicht in Kilogramm an");
    eingabeKorrekt = double.TryParse(Console.ReadLine(), out gewicht);

    if(eingabeKorrekt) Console.WriteLine("Der User wiegt " + gewicht + " Kilogramm");
    else Console.WriteLine("Die Eingabe war ungültig.");
}

//Berechnung des Promillewerts und Ausgabe der entsprechenden Meldung
if (eingabeKorrekt)
{
    double promille = Reinalkohol / (0.65 * gewicht); // Berechnung des Promillewerts
    Console.WriteLine($"Der User hat {promille:f2} Promille");

    if (promille <= 0.3)
    {
        Console.WriteLine("Noch akzeptabel. Dennoch vorsichtig sein!");
    }
    else if (promille <= 0.5)
    {
        Console.WriteLine("Achtung! Hände weg vom Steuer!");
    }
    else if (promille <= 0.8)
    {
        Console.WriteLine("Das ist jetzt schon ganz schön ordentlich.");
    }
    else if (promille > 0.8)
    {
        Console.WriteLine("Kein Kommentar...");
    }
    else
    {
        Console.WriteLine("Etwas ist schief gelaufen...");
    }
    Console.ReadKey();
}