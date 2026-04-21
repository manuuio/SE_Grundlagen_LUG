using System;


Console.Write("Eingabe: ");
string input = Console.ReadLine() ?? "";


if (bool.TryParse(input, out bool b))
{
    Console.WriteLine($"Typ: bool | Input: {b}");
}
else if (long.TryParse(input, out long l))
{
    Console.WriteLine("Mehrere mögliche Typen:");
    Console.WriteLine("1: byte");
    Console.WriteLine("2: short");
    Console.WriteLine("3: int");
    Console.WriteLine("4: long");
}
else if (double.TryParse(input, out double d))
{
    Console.WriteLine("Mehrere mögliche Typen:");
    Console.WriteLine("1: float");
    Console.WriteLine("2: double");
    Console.WriteLine("3: decimal");
}
else
{
    Console.WriteLine($"Typ: string | Input: {input}");
}
