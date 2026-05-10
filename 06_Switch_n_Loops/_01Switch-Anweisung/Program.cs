int schulnote;

//User gibt die Schulnote ein
Console.WriteLine("Gib eine Note ein");
schulnote = int.Parse(Console.ReadLine());

//Werte die Schulnote aus mithilfe der Switch-Anweisung aus

switch (schulnote) /*Selektor*/
{
    case 1:
        Console.WriteLine("Note ist sehr gut");
        // goto case 3;
        break;  /*Verlassen der Switch-Anweisung*/
    case 2:
        Console.WriteLine("Note ist gut");
        break;
    case 3:
        Console.WriteLine("Note ist befriedigend");
        break;
    case 4: 
        Console.WriteLine("Note ist ausreichend");
        break;
    case 5: 
        Console.WriteLine("Note ist mangelhaft");
        break;
   case 6:
        Console.WriteLine("Note ist ungenügend");
        break;
    default: /*default-Label, wenn kein case-Label zutrifft*/
        Console.WriteLine("Ungültige Note");
        break;
}

// Die Switch-Anweisung ist sinnvoll, wenn mehrere Fälle und alle Ausdrücke *konstante Werte* sind. Sie ist übersichtlicher als eine lange if-else-if-Kette, wenn es viele Fälle gibt.

