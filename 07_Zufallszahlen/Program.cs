namespace Zufallszahlen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            // Untergrenze inkl., Obergrenze exkl.
            int z = rnd.Next(1, 101);   // 1-100

        }
    }
}
