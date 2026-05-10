namespace _09_Methoden03_MehrereRueckgabeWerte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int add, multi;

            add = AddMulti(4, 5, out multi);

        }
        static int AddMulti(int a, int b, out int multi)
        {
            multi = a * b;
            return a + b;
        }
    }
}
