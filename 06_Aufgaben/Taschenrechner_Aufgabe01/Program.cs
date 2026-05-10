//Erstellen Sie ein Konsolenprogramm, das die vier Grundrechenarten (Addition, Subtraktion, Multiplikation, Division) unterstützt.

//- Verwenden Sie eine do-while-Schleife, damit das Programm wiederholt ausgeführt wird, bis der Benutzer es beenden möchte.
//- Gestalten Sie eine einfache Konsolenoberfläche, die den Benutzer nach der gewünschten Rechenoperation und den beiden Operanden fragt.
//- Nutzen Sie eine switch-Anweisung, um die gewählte Operation auszuführen und das Ergebnis anzuzeigen.
//- Validieren Sie die Benutzereingaben. Behandeln Sie auch den Fall, dass eine ungültige Operation gewählt oder durch Null geteilt wird.
//- Zeigen Sie das Ergebnis auf der Konsole an und fragen Sie, ob eine weitere Berechnung durchgeführt werden soll.

//---

//4. Interaktive Menü
//string eingabe;

do
{
    //Console.Clear();
    Console.WriteLine("****** Menü:");
    Console.WriteLine("\tOption 1: Addieren");
    Console.WriteLine("\tOption 2: Subtrahieren");
    Console.WriteLine("\tOption 3: Multiplizieren");
    Console.WriteLine("\tOption 4: Dividieren");
    Console.WriteLine("\tOption 5: Beenden");
    Console.WriteLine("****** Antworte mit 1, 2, 3, 4 oder 5:");
    //eingabe = Console.ReadLine() ?? "";
    if(!int.TryParse((Console.ReadLine() ?? ""), out int eingabe) || eingabe < 1 || eingabe > 5)
    {
        Console.WriteLine("Ungültige Option.");
        continue;
    }

    if (eingabe == 5)
    {
        Console.WriteLine("Der Taschenrechner wird beendet...");
        Thread.Sleep(1000);
        Environment.Exit(0);
    }

    Console.WriteLine("1.) Zahl:");
    bool numOneValid = int.TryParse(Console.ReadLine(), out int numOne);
    Console.WriteLine("2.) Zahl:");
    bool numTwoValid = int.TryParse(Console.ReadLine(), out int numTwo);

    switch (eingabe)
    {
        case 1:
            if (numOneValid && numTwoValid)
            {
                int result = numOne + numTwo;
                Console.WriteLine($"Ergebniss: {result}\n");
                Thread.Sleep(1000);
            }
            else Console.WriteLine("Keine Zahl!");
            break;
        case 2:
            if (numOneValid && numTwoValid)
            {
                int result = numOne - numTwo;
                Console.WriteLine($"Ergebniss: {result}\n");
                Thread.Sleep(1000);
            }
            else Console.WriteLine("Keine Zahl!");
            break;
        case 3:
            if (numOneValid && numTwoValid)
            {
                int result = numOne * numTwo;
                Console.WriteLine($"Ergebniss: {result}\n");
                Thread.Sleep(1000);
            }
            else Console.WriteLine("Keine Zahl!");
            break;
        case 4:
            if (numOneValid && numTwoValid)
            {
                int? result = numOne / numTwo;
                Console.WriteLine($"Ergebniss: {result}\n");
                Thread.Sleep(1000);
            }
            else Console.WriteLine("Keine Zahl!");
            break;
        default:
            Console.WriteLine("Ungültige Option.");
            break;
    }

} while (true);