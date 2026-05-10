using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Aufgabe01_Person
{
    internal class Persion
    {
        private string vorname;
        private string nachname;

        public void SetzeVorname(string vorname)
        {
            this.vorname = vorname;
        }

        public void SetzeNachname(string vorname)
        {
            this.nachname = nachname;
        }

        public void SagHallo()
        {
            Console.WriteLine($"Hallo! Ich bin {vorname} {nachname}");
        }
    }
}
