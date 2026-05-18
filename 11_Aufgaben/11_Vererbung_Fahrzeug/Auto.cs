using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Vererbung_Fahrzeug
{
    //abgeleitete Klasse: erbt von Fahrzeug und fügt spezifische Eigenschaften und Methoden für Auto hinzu
    public class Auto : Fahrzeug
    {
        private int _anzahlTueren;

        //Konstruktor der Basisklasse aufrufen
        public Auto(string marke, int baujahr, int anzahlTueren) : base(marke, baujahr)
        {
            this._anzahlTueren = anzahlTueren;
        }

        // "override" Methodenüberschreibung: spezifisches Verhalten für Autos implementieren
        public override string Starten()
        {
            string autoGestartet = "Das Auto wurde gestartet.";
            return autoGestartet;
        }
    }
}
