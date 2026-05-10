using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_OOP01
{
    internal class Person
    {
        // Felder
        public string name;   // Zugriffsmodifikator: public, private, internal, protected
        public string wohnort;
        public DateTime gebDat;
        public int kdNr;

        // Konstruktoren
        public Person() { }
        public Person(string name, string wohnort, DateTime gebDat,
            int kdNr)
        {
            this.name = name;
            this.wohnort = wohnort;
            this.gebDat = gebDat;
            this.kdNr = kdNr;
        }

        // Objekt-bezogene Methoden / nicht-statische Methoden
        public void Ausgabe()
        {
            Console.WriteLine($"Name: {name}");
        }

        // statische Methoden
        public static void Hallo()
        {
            Console.WriteLine($"Hallo!");
        }
    }
}
