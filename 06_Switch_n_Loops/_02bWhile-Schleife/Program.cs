
//While-Schleife

//kopfgesteurte WHile-Schleife: erst Prüfen, dann Handeln
int aktuellerTankinhalt = 50;
int maximalerTankinhalt = 100;

while (aktuellerTankinhalt < maximalerTankinhalt)
{
    Console.WriteLine("Der Tank ist noch nicht voll. Aktueller Tankinhalt: " + aktuellerTankinhalt + " Liter");
    aktuellerTankinhalt += 10; /*Erhöhe den aktuellen Tankinhalt um 10 Liter*/
    Console.WriteLine("Benzin fließt");
    Thread.Sleep(1000); /*Pause von 1 Sekunde (1000 Millisekunden)*/
}

Console.WriteLine("Tank ist voll!");




//fußgesteuerte WHile-Schleife: erst Handeln, dann Prüfen

string passwort;
do
{
    Console.WriteLine("Bitte geben Sie das geheime Passwort ein");
    passwort = Console.ReadLine();

} while (passwort != "123geheim");

Console.WriteLine("Zugriff gewährt wurde...");