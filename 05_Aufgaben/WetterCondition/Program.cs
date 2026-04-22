
//Console.WriteLine($"Ist das Wetter heute sonnig oder regnerisch? \nBitte antowrte mit 'sonnig' oder 'regnerisch'");
//string wetterZustand = Console.ReadLine()?.ToLower() ?? "";


//if (wetterZustand == "sonnig")
//{
//    Console.WriteLine($"Wie viel Grad (Celsius) hat es heute?");
//    string wetterTemperatur = Console.ReadLine() ?? "";
//    if (int.TryParse(wetterTemperatur, out int intWetterTemp))
//    {
//        if (intWetterTemp >= 20)
//        {
//            Console.WriteLine("Es ist ziemlich warm. Ich empfehle ein T-Shirt zu tragen.");
//        }
//        else
//        {
//            Console.WriteLine("Es ist etwas kühl. Ich empfehle eine Jacke anzuziehen.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Keine gültige Temperatur.");
//    }

//}
//else if (wetterZustand == "regnerisch")
//{
//    Console.WriteLine($"Wie viel Grad (Celsius) hat es heute?");
//    string wetterTemperatur = Console.ReadLine() ?? "";
//    if (int.TryParse(wetterTemperatur, out int intWetterTemp))
//    {
//        if (intWetterTemp >= 20)
//        {
//            Console.WriteLine("Es ist ziemlich warm. Ich empfehle ein T-Shirt zu tragen sowie einen Regenschirm mitzunehmen.");
//        }
//        else
//        {
//            Console.WriteLine("Es ist etwas kühl. Ich empfehle eine Jacke anzuziehen sowie einen Regenschirm mitzunehmen.");
//        }
//    }
//    else
//    {
//        Console.WriteLine("Keine gültige Temperatur.");
//    }
//}
//else
//{
//    Console.WriteLine("Kein gültiges Wetter.");
//}


// SHORT VERSION:
Console.WriteLine($"Ist das Wetter heute sonnig oder regnerisch? \nBitte antowrte mit 'sonnig' oder 'regnerisch'");
string Wetter = Console.ReadLine()?.ToLower() ?? "";

if (Wetter == "sonnig" || Wetter == "regnerisch")
{
    Console.WriteLine($"Wie viel Grad (Celsius) hat es heute?");
    string? Temperatur = Console.ReadLine();

    //Convert.ToInt32 crashes on invalid input, TryParse doesn't
    if (int.TryParse(Temperatur, out int intWetterTemp))
    {
        if (Wetter == "sonnig" && intWetterTemp >= 20)
        {
            Console.WriteLine($"Das Wetter ist {Wetter} und es sind {Temperatur} Grad, ziehe ein T-Shirt an.");
        }
        else if (Wetter == "sonnig" && intWetterTemp < 20)
        {
            Console.WriteLine($"Das Wetter ist {Wetter} und es sind {Temperatur} Grad, ziehe eine Jacke an.");
        }
        else if (Wetter == "regnerisch" && intWetterTemp >= 20)
        {
            Console.WriteLine($"Das Wetter ist {Wetter} und es sind {Temperatur} Grad, ziehe ein T-Shirt an und nimm einen Schirm mit.");
        }
        else if (Wetter == "regnerisch" && intWetterTemp < 20)
        {
            Console.WriteLine($"Das Wetter ist {Wetter} und es sind {Temperatur} Grad, ziehe eine Jacke an und nimm einen Schirm mit.");
        }
    }
    else
    {
        Console.WriteLine("Keine richtige Temperatur eingegeben.");
    }
}
else
{
    Console.WriteLine("Kein richtiges Wetter eingegeben.");
}