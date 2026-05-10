

// For-Schleife: zählergesteuerte Schleife



//abwärtszählende For-Schleife
//Countdown
for (int i = 3; i >= 0; i--) /*verringere i um 1 (Dekrement)*/
{
    Console.WriteLine(i);
    Thread.Sleep(1000); /*Pause von 1 Sekunde (1000 Millisekunden)*/
}

Console.WriteLine("Start!");


/*1) Initialwert 2) Abbruchbedingung 3) Schrittweite*/
for (int i = 1; i <= 10; i++)  /*vergrößere i um 1 (Inkrement)*/
{
    Thread.Sleep(500);
    Console.WriteLine("Ich darf nicht quatschen (" + i + ")");
}









