/*
3. Die while-Schleife: "Die Geduldsprobe"
Szenario: Eine Abfrage soll so lange wiederholt werden, bis eine bestimmte Bestätigung erfolgt.
 
 
Schleife gibt "Sind wir schon da?" aus und erwartet Eingabe
Solange Eingabe nicht "Ja" (oder "ja") ist, wiederholen
Bei "Ja": "Endlich!" ausgeben
 
 
4. Die do-while-Schleife: "Das interaktive Menü"
Szenario: Ein Konsolenprogramm soll erst beendet werden, wenn dies explizit bestätigt wird. Menü wird immer mindestens einmal angezeigt.
*/

bool keepLooping = true;
while (keepLooping)
{
    Console.WriteLine("Sind wir schon da?");
    string schonDa = Console.ReadLine()?.ToLower() ?? "";
    if (schonDa == "ja")
    {
        Console.WriteLine("Endlich!");
        Thread.Sleep(1000);
        keepLooping = false;
    }
}

//bool keepOpen = true;
//do
//{
//    Console.WriteLine("Konsolenmenu: 1: Spielen 2: Exit.");
//    string command = Console.ReadLine()?.ToLower() ?? "";
//    if (command == "exit") keepOpen = false;
//} while(keepOpen);


//4. Interaktive Menü
string eingabe;

do
{
    Console.Clear();
    Console.WriteLine("****** Menü:");
    Console.WriteLine("\tOption 1: Hallo sagen");
    Console.WriteLine("\tOption 2: Uhrzeit anzeigen");
    Console.WriteLine("\tOption 3: Beenden");
    eingabe = Console.ReadLine() ?? "";

}
while (eingabe != "3");