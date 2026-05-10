namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Arrays: hat eine fixe Größe, welche nach Instanziierung nicht mehr
            // verändert werden kann
            int[] intArr = new int[6];
            intArr[0] = 42;
            intArr[1] = 21;
            intArr[2] = 17;
            intArr[3] = 38;
            intArr[4] = 57;
            intArr[5] = 8;

            Console.WriteLine(intArr[3]);

            // Kurzschreibweise
            int[] intArr2 = { 17, 38, 5, 19, 7 };
            string[] str1 = { "Hallo", "Hi", "Grüß Gott" };

            // Länge des Arrays abfragen: "Length"
            Console.WriteLine(intArr.Length);
            Console.WriteLine();

            // Alle Werte ausgeben
            for (int i = 0; i < intArr.Length; i++)
            {
                Console.WriteLine(intArr[i]);
            }
            Console.WriteLine();

            // foreach: Spezialisierte for-Schleife für Collections
            foreach (var item in intArr)
            {
                Console.WriteLine(item);
            }

            // Alle Werte ausgeben: Rückwärts
            for (int i = intArr.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(intArr[i]);
            }

            string s3 = "Hallo Welt";
            
            
        }
    }
}
