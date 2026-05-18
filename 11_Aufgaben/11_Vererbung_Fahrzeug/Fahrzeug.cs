namespace _11_Vererbung_Fahrzeug
{
    /*
        Der digitale Fuhrpark
        Ein Autohaus möchte seine Fahrzeugflotte digital verwalten. 
        Es gibt verschiedene Arten von Fahrzeugen, die alle einige Gemeinsamkeiten aufweisen (z. B. die Marke und das Baujahr), 
        sich aber in ihren spezifischen Eigenschaften und im Startverhalten voneinander unterscheiden. 
     */

    public class Fahrzeug
    {
        private string _marke;
        private int _baujahr;

        static void Main(string[] args)
        {
            Fahrzeug meinFahrzeug = new Fahrzeug("Generisches Fahrzeug", 1990);
            Auto meinAuto = new Auto("Mercedes", 2024, 5);
            Motorrad meinMotorrad = new Motorrad("BMW", 2020, false);
            Elektroauto meinElektroauto = new Elektroauto("Tesla", 2021, 60);

            //Console.WriteLine($"Mein Auto: {meinAuto.Starten()}");

            List<Fahrzeug> meineFahrzeugListe = new List<Fahrzeug>() { meinFahrzeug, meinAuto, meinMotorrad, meinElektroauto };

            foreach (var item in meineFahrzeugListe)
            {
                Console.WriteLine(item.Starten());
            }

        }

        public Fahrzeug(string marke, int baujahr)
        {
            this._marke = marke;
            this._baujahr = baujahr;
        }

        //virtuelle Methode: ermöglicht es abgeleiteten (Kind) Klassen, diese Methode zu überschreiben und spezifisches Verhalten zu implementieren
        public virtual string Starten()
        {
            string gestartet = "Das Fahrzeug wurde gestartet.";
            return gestartet;
        }
    }
}
