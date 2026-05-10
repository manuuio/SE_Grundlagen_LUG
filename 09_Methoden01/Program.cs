using System.Threading.Channels;

namespace _09_Methoden01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Methode ohne Paramter
            Hallo();
            Hallo();
            Hallo();

            // Methode mit einem Parameter
            Hi("Agathe Bauer");

            string s1 = "Karl";
            Hi(s1);

            // Methode mit mehreren Parametern
            Ahoi("Hanz Dampf", 36);
            Ahoi("Agent 47", 47);

            // Rückgabwert
            int ergebnis = Addieren(20, 22);
            Console.WriteLine(Addieren(18, 24));
            Console.WriteLine(Addieren(Addieren(5, 7), Addieren(18, 12)));

        }
        static int Addieren(int z1, int z2)
        {
            int erg = z1 + z2;
            return erg;
        }
        static void Ahoi(string name, int alter)
        {
            Console.WriteLine($"Ahoi, {name}!");
            Console.WriteLine($"Sie sind {alter} Jahre alt.");
        }
        static void Hi(string name)
        {
            Console.WriteLine($"Sei gegrüßt, {name}!");
        }
        // static (Ja/Nein) Rückgabewert Bezeichner Klammern(evtl. Parameter)
        static void Hallo()
        {
            Console.WriteLine("Hallo!");
        }
    }
}
