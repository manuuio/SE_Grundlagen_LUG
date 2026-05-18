using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Vererbung_Fahrzeug
{
    //abgeleitete Klasse: erbt von Fahrzeug und fügt spezifische Eigenschaften und Methoden für Elektroauto hinzu
    public class Elektroauto : Fahrzeug
    {
        private int _batterieKapazitaet;

        //Konstruktor der Basisklasse aufrufen
        public Elektroauto(string marke, int baujahr, int batterieKapazitaet) : base(marke, baujahr)
        {
            this._batterieKapazitaet = batterieKapazitaet;
        }

        // "override" Methodenüberschreibung: spezifisches Verhalten für Elektroauto implementieren
        public override string Starten()
        {
            string elektroautoStarten = "Das Elektroauto wurde gestartet.";
            return elektroautoStarten;
        }
    }
}
