namespace _03Liste;

internal class Program
{
    static void Main(string[] args)
    {
        //Array: Festgelegte Anzahl von Elementen, die denselben Datentyp haben
        int[] lottozahlen = new int[6] { 1, 2, 3, 4, 5, 6 };
        lottozahlen[0] = 7; //Element an Index 0 ändern

        //Liste: Dynamische Anzahl von Elementen, die denselben Datentyp haben
        List<int> zahlenListe = new List<int>() { 1, 2, 3, 4, 5, 6 };
        zahlenListe.Add(7); //Element hinzufügen
        zahlenListe.Add(34);

        //Auch die List ist indizierbar
        zahlenListe[0] = 10; //Element an Index 0 ändern

        bool entfernt = zahlenListe.Remove(34);

        //zahlenListe.Clear(); //Alle Elemente entfernen
        int anzahl = zahlenListe.Count();


        for (int i = 0; i < zahlenListe.Count(); i++)
        {
            Console.WriteLine(zahlenListe[i]);
        }

        foreach (var item in zahlenListe)
        {
            Console.WriteLine(item);
        }
    }


}