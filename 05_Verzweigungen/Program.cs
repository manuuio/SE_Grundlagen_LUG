using System.ComponentModel.Design;

bool b1 = true && true == true == true;
//b1 ist eine boolesche Variable, die den Wert true oder false speichern kann. In diesem Fall wird b1 mit dem Ergebnis der logischen Operation "true && true == true == false" initialisiert. Die logische Operation wird von links nach rechts ausgewertet, wobei "&&" die logische UND-Operation und "==" die Gleichheitsprüfung darstellt. Das Ergebnis dieser Operation wird in b1 gespeichert, und je nachdem, ob es wahr oder falsch ist, wird die entsprechende Ausgabe auf der Konsole angezeigt.

// Eine Verzweigung ist eine Kontrollstruktur in der Programmierung, die es ermöglicht, unterschiedliche Anweisungen basierend auf bestimmten Bedingungen auszuführen. In diesem Fall wird die Bedingung "b1" überprüft. Wenn b1 true ist, wird die Anweisung innerhalb des if-Blocks ausgeführt, andernfalls wird sie übersprungen. In diesem Beispiel wird die Nachricht "b1 ist wahr!" auf der Konsole ausgegeben, wenn b1 den Wert true hat. Wenn b1 false ist, wird keine Ausgabe erzeugt, da der if-Block nicht ausgeführt wird. Verzweigungen sind ein grundlegendes Konzept in der Programmierung und ermöglichen es, den Fluss eines Programms basierend auf verschiedenen Bedingungen zu steuern.

if (b1) //WENN BEDINGUNG WAHR IST, DANN FÜHRE ANWEISUNGEN DARUNTER AUS 
{
    Console.WriteLine("b1 ist wahr!");
}
else //ANDERNFALLS, WENN BEDINGUNG FALSCH IST, DANN FÜHRE ANWEISUNGEN DARUNTER AUS 
{
    Console.WriteLine("b1 ist falsch!");
}


int alterPerson1 = 18;

if (alterPerson1 == 18 || alterPerson1 == 30)
{
    Console.WriteLine("Person1 ist 18 oder 30");

    if (alterPerson1 == 18)
    {
        Console.WriteLine("Person 1 ist volljährig.");
        Console.WriteLine("Die Person wurde an ihrem letzten Geburstag Volljährig");
        
    }
}
else if (alterPerson1 > 18) //ANDERNFALLS, WENN BEDINGUNG WAHR IST, DANN FÜHRE ANWEISUNGEN DARUNTER AUS 
{
    Console.WriteLine("Person 1 ist volljährig.");
}
else if (alterPerson1 < 0) //ANDERNFALLS, WENN BEDINGUNG WAHR IST, DANN FÜHRE ANWEISUNGEN DARUNTER AUS 
{
    Console.WriteLine("Das Alter von Person 1 ist ungültig.");
}
//else if (alterPerson1 == 18 || alterPerson1 == 30) //WIRD NIEMALS AUSGEFÜHRT
//{
//    Console.WriteLine("Person1 ist 18 oder 30");
//}
else
{
    Console.WriteLine("Person 1 ist minderjährig.");
}

//Eine if-else Kontrollstruktur beginnt immer mit einem if statement
//beinahltet optional einen oder mehrere else if statements, die zusätzliche Bedingungen überprüfen, wenn die vorherigen Bedingungen nicht erfüllt sind.
//und endet optional mit einem else statement, das ausgeführt wird, wenn keine der vorherigen Bedingungen wahr ist. Es ist wichtig zu beachten, dass die Bedingungen in den if und else if statements von oben nach unten überprüft werden, und sobald eine Bedingung als wahr bewertet wird, werden die entsprechenden Anweisungen ausgeführt und die restlichen Bedingungen übersprungen. Wenn keine der Bedingungen wahr ist und ein else statement vorhanden ist, werden die Anweisungen im else block ausgeführt.

//Die Erfüllung eines statements (also einer Bedinung ) lässt das Programm aus der Kontrollstruktur austeigen, bedeutet das danach kommende Bedinungen nicht mehr überprüft werden, da die Kontrollstruktur bereits verlassen wurde. Zum Beispiel, wenn die erste Bedingung in einem if statement wahr ist, werden die Anweisungen im if block ausgeführt und die restlichen Bedingungen (else if und else) werden nicht mehr überprüft, da das Programm bereits aus der Kontrollstruktur ausgetreten ist. Es ist wichtig, die Reihenfolge der Bedingungen sorgfältig zu planen, um sicherzustellen, dass die gewünschten Anweisungen ausgeführt werden und unerwartete Ergebnisse vermieden werden.
if(true == true)
{
    Console.WriteLine("true ist true");
}
else if(true != false)//Diese Bedingung wird nicht mehr überprüft, da die vorherige Bedingung bereits wahr ist und die Kontrollstruktur verlassen wurde.
{
    Console.WriteLine("true ist nicht false");
}

//Wenn wir mehere Bedingungen haben die zutreffen sollen, nutzen wir einfach mehrere Kontrollstrukturen untereinander.
if(true == true)
{
    Console.WriteLine("true ist true");
}
if(true != false)//Diese Bedingung wird überprüft, da es sich um eine separate Kontrollstruktur handelt und die vorherige Bedingung keinen Einfluss auf diese hat.
{
    Console.WriteLine("true ist nicht false");
}

//Aufgabe:
//Der User soll ein Passwort eingeben. Er hat drei Versuche um das Passwort richtig einzugeben.
//Nach jedem Fehlversuch, soll angegeben werden wieviele Versuche übrig bleiben.
//Nach dem dritten Fehlversuch soll die Meldung kommen: "Konto gesperrt."