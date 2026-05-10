namespace _10_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // CLS = Common Language Specification
            Person p1 = new Person();
            p1.name = "Agathe Bauer";
            p1.wohnort = "Bielefeld";
            p1.gebDat = new DateTime(2001, 12, 15);
            p1.kdNr = 42;

            Console.WriteLine(p1.name);

            Person p2 = new Person();
            p2.name = "Hanz Dampf";
            p2.wohnort = "Backnang";
            p2.gebDat = new DateTime(1987, 8, 21);
            p2.kdNr = 333;

            Person p3 = new Person("Master Chef", "Hier und da",
                new DateTime(2427, 6, 3), 117);
            p3.name = "Master Chief";

            p1.Ausgabe();
            p2.Ausgabe();
            Person.Hallo();




            //Person[] persListe = { p1, p2 };

            //string name1 = "Agathe Bauer";
            //string wohnort1 = "Bielefeld";
            //DateTime gebDat1 = new DateTime(2001, 12, 15);
            //int kdNr1 = 42;

            //string name2 = "Hanz Dampf";
            //string wohnort2 = "Backnang";
            //DateTime gebDat2 = new DateTime(1987, 8, 21);
            //int kdNr2 = 333;

            //string[] name = { "Agathe Bauer", "Hanz Dampf" };
            //string[] wohnort = { "Bielefeld", "Backnang" };
            //DateTime[] gebDat = { new DateTime(2001, 12, 15), new DateTime(1987, 8, 21) };
            //int[] kdNr = { 42, 333 };

        }
    }
}
