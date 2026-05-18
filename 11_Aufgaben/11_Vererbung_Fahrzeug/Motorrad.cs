using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Vererbung_Fahrzeug
{
    //abgeleitete Klasse: erbt von Fahrzeug und fügt spezifische Eigenschaften und Methoden für Motorrad hinzu
    public class Motorrad : Fahrzeug
    {
        public bool HatBeiwagen;

        //Konstruktor der Basisklasse aufrufen
        public Motorrad(string marke, int baujahr, bool hatBeiwagen) : base(marke, baujahr)
        {
            this.HatBeiwagen = hatBeiwagen;
        }

        // "override" Methodenüberschreibung: spezifisches Verhalten für Motorrad implementieren
        public override string Starten()
        {
            string motorrad_gestartet = "Das Motorrad wurde gestartet.";
            return motorrad_gestartet;
        }
    }
}
