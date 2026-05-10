namespace Typkonvertierung
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implizite Typkovertierung
            int i1 = 42;
            double d1 = i1;

            // explizite Typkonvertierung
            double d2 = 42;
            int i2 = (int)d2;   // casten

            // string in einen Zahlenwert
            string s1 = "42";
            int i3 = int.Parse(s1);

            // TryParse
            string s2 = "Hallo";
            int i4;
            bool b;

            b = int.TryParse(s2, out i4);

        }
    }
}
