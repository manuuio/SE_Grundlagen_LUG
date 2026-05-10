namespace _09_Methoden02_Ueberladung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Methoden-Überladung
            // Unterscheidungen:
            // 1 => Anzahl der Parameter
            // 2 => Datentypen
            // 3 => Reihenfolge der Datentypen
            Addieren(17, 4);
            Addieren(1, 2, 3);
            Addieren(1, 2, 3, 4);
            Addieren(6.3, 15.7);



        }
        static void Addieren(double d1, int d2)
        {
            double erg = d1 + d2;
            Console.WriteLine(erg);
        }
        static void Addieren(int d1, double d2)
        {
            double erg = d1 + d2;
            Console.WriteLine(erg);
        }
        static void Addieren(double d1, double d2)
        {
            double erg = d1 + d2;
            Console.WriteLine(erg);
        }
        static void Addieren(int z1, int z2, int z3, int z4)
        {
            int erg = z1 + z2 + z3 + z4;
            Console.WriteLine($"Ihr Ergebnis ist: {erg}");
        }
        static void Addieren(int z1, int z2, int z3)
        {
            int erg = z1 + z2 + z3;
            Console.WriteLine($"Ihr Ergebnis ist: {erg}");
        }
        static void Addieren(int z1, int z2)
        {
            int erg = z1 + z2;
            Console.WriteLine($"Ihr Ergebnis ist: {erg}");
        }
    }
}
