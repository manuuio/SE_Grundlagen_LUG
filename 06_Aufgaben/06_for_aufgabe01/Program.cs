/*
2. Die for-Schleife: "Das Sparschwein-Wachstum"
Szenario: Jemand möchte monatlich einen festen Betrag in ein Sparschwein stecken und sehen, wie der Betrag über ein Jahr hinweg wächst.
 
 
Programm fragt, wie viel Geld jeden Monat gespart wird (z. B. 25 Euro)
Mit einer for-Schleife von Monat 1 bis 12 die Gesamtsumme berechnen
Ziel der Ausgabe:
 
Monat 1: Sie haben bisher 25 Euro gespart.
Monat 2: Sie haben bisher 50 Euro gespart.
...
Monat 12: Sie haben bisher 300 Euro gespart.
*/

Console.WriteLine("Wie viel Geld sparst du jeden Monat? (z.B.: 25 Euro)");
int? sparBetrag = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= 12; i++)
{
    Console.WriteLine($"Sie haben bisher {sparBetrag * i} gespart.");
}