namespace _06vererbung;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        Tier tier = new Tier("GenericAnimal", 5);
        Katze katze = new Katze("Mia", 2, "Schwarz");
        Hund hund = new Hund("Bello", 3, "Labrador");

        List<Tier> tiere = new List<Tier> { tier, katze, hund };

        foreach (var t in tiere)
        {
            t.GibNameAus();
            t.GibAlterAus();
            t.MachGeraeusch();
            Console.WriteLine();
        }
    }
}

class Tier  //Basisklasse: enthält allgemeine Eigenschaften und Methoden für alle Tiere
{
    protected string _name;
    protected int _alter;

    public Tier(string name, int alter)
    {
        _name = name;
        _alter = alter;
    }

    public void GibNameAus()
    {
        Console.WriteLine($"Der Name des Tieres ist {_name}");
    }

    public void GibAlterAus()
    {
        Console.WriteLine($"Das Alter des Tieres ist {_alter}");
    }

    public virtual void MachGeraeusch()  //virtuelle Methode: ermöglicht es abgeleiteten Klassen, diese Methode zu überschreiben und spezifisches Verhalten zu implementieren
    {
        Console.WriteLine("Das Tier macht ein Geräusch");
    }
}

class Hund : Tier  //abgeleitete Klasse: erbt von Tier und fügt spezifische Eigenschaften und Methoden für Hunde hinzu
{
    private string _rasse;
    public Hund(string name, int alter, string rasse) : base(name, alter) //Konstruktor der Basisklasse aufrufen
    {
        _rasse = rasse;
    }
    public void GibRasseAus()
    {
        Console.WriteLine($"Die Rasse des Hundes ist {_rasse}");
    }
    public override void MachGeraeusch() //Methodenüberschreibung: spezifisches Verhalten für Hunde implementieren
    {
        Console.WriteLine("Der Hund bellt");
    }
}

class Katze : Tier  //abgeleitete Klasse: erbt von Tier und fügt spezifische Eigenschaften und Methoden für Katzen hinzu
{
    private string _farbe;
    public Katze(string name, int alter, string farbe) : base(name, alter) //Konstruktor der Basisklasse aufrufen
    {
        _farbe = farbe;
    }
    public void GibFarbeAus()
    {
        Console.WriteLine($"Die Farbe der Katze ist {_farbe}");
    }
    public override void MachGeraeusch() //Methodenüberschreibung: spezifisches Verhalten für Katzen implementieren
    {
        Console.WriteLine("Die Katze miaut");
    }
}