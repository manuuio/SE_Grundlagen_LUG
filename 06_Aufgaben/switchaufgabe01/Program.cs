/*
1. Die switch-Anweisung: "Der digitale Kellner"
Szenario: Ein Gast betritt ein digitales Café und möchte ein Getränk bestellen.
 
 
Programm gibt aus: "Was möchten Sie trinken? (Kaffee, Tee, Schokolade)"
Mit switch je nach Eingabe passende Antwort ausgeben (z. B. bei Kaffee: "Hier ist Ihr heißer Wachmacher!")
default-Fall für unbekannte Getränke
*/

Console.WriteLine("Was möchten sie trinken? (Kaffee, Tee, Schokolade)");
string getraenk = Console.ReadLine()?.ToLower() ?? "";

switch(getraenk)
{
    case "kaffee":
        Console.WriteLine("Hier ist Ihr heißer Wachmacher!");
        break;
    case "tee":
        Console.WriteLine("Hier ist dein Warmmacher!");
        break;
    case "schokolade":
        Console.WriteLine("Hier ist deine Schokolade!");
        break;
    default:
        Console.WriteLine($"{getraenk} haben wir nicht.");
        break;
}