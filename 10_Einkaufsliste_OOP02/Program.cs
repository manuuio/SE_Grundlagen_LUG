namespace _04Einkaufsliste;

internal class Program
{
    static void Main(string[] args)
    {
        Einkaufsliste einkaufsliste = new Einkaufsliste();

        einkaufsliste.Add("Milch");
        einkaufsliste.Add("Brot");

        Console.WriteLine($"Anzahl Elemente: {einkaufsliste.AnzahlElemente()}"); //2 
        einkaufsliste.Entfernen("Milch");
        bool istBrotEnthalten = einkaufsliste.IstEnthalten("Brot");
        Console.WriteLine($"Brot ist enthalten: {istBrotEnthalten}");

        einkaufsliste.Leeren();
        Console.WriteLine($"Anzahl Elemente nach Leeren: {einkaufsliste.AnzahlElemente()}");  //0

        einkaufsliste.Add("Äpfel");
        einkaufsliste.Add("Bananen");
        einkaufsliste.Add("Orangen");

        einkaufsliste.AlleElementeAnzeigen();
    }

}