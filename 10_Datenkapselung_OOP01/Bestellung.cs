namespace _01Datenkapselung;

class Bestellung
{
    //Felder = Instanzvariablen
    private string _artikel;
    private int _menge = 1;
    private double _preis = 0.0;
    private DateTime _bestellzeitpunkt;  // kennzeichne Instanzvariablen mit Unterstrich (um sie von lokalen Variablen zu unterscheiden)




    //Konstruktor: initialisiert die Felder der Klasse
    public Bestellung(string artikel, int menge, double preis, DateTime bestellzeitpunkt)
    {
        SetArtikel(artikel);
        SetMenge(menge);
        SetPreis(preis);
        SetBestellzeitpunkt(bestellzeitpunkt);
    }

    //Konstruktorüberladung: ruft den anderen Konstruktor mit Standardwerten auf  (Kettenkonstruktor)
    public Bestellung() : this("", 1, 0.0, DateTime.Now)  //Konstruktorenverkettung: ruft den anderen Konstruktor mit Standardwerten auf
    {

    }


    //Methoden 
    public void SetArtikel(string artikel)
    {
        //Kapselung: Zugriff auf das private Feld _artikel nur über die Methode SetArtikel
        if (artikel.Length < 2)
        {
            return; // brich die Methode ab
        }
        _artikel = artikel;
    }

    public void SetMenge(int menge)
    {
        if (menge < 1)
        {
            return; // brich die Methode ab
        }
        _menge = menge;
    }

    public void SetPreis(double preis)
    {
        if (preis < 0)
        {
            return; // brich die Methode ab
        }
        _preis = preis;
    }

    public void SetBestellzeitpunkt(DateTime bestellzeitpunkt)
    {
        if (bestellzeitpunkt > DateTime.Now)
        {
            _bestellzeitpunkt = DateTime.Now;
            return; // brich die Methode ab
        }

        _bestellzeitpunkt = bestellzeitpunkt;
    }


    public void BestellInfoAnzeigen()
    {
        Console.WriteLine($"Name: {_artikel}, Menge: {_menge}, Preis: {_preis * _menge} (Grundpreis: {_preis}), Bestellzeitpunkt: {_bestellzeitpunkt.ToShortDateString()}");
    }

}


