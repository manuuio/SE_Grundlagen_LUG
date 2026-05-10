

namespace _04Einkaufsliste;

internal class Einkaufsliste
{
    //Feld
    private List<string> _elemente = new List<string>();

    public void Add(string element)
    {
        if (element.Length < 2)
        {
            Console.WriteLine("Element ist zu kurz.");
            return;
        }
        _elemente.Add(element);
    }

    public void Entfernen(string element)
    {
        if (!_elemente.Contains(element))
        {
            Console.WriteLine("Element ist nicht in der Einkaufsliste enthalten.");
            return;
        }
        _elemente.Remove(element);
    }

    public void Leeren()
    {
        _elemente.Clear();
    }

    public bool IstEnthalten(string element)
    {
        return _elemente.Contains(element);
    }

    public int AnzahlElemente()
    {
        return _elemente.Count;
    }

    public void AlleElementeAnzeigen()
    {
        foreach (var element in _elemente)
        {
            Console.WriteLine(element);
        }
    }

    public void Sortiere()
    {
        _elemente.Sort();
    }
}
