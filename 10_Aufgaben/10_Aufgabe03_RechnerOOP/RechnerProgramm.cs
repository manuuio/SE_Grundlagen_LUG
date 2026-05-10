using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RechnerProgramm
{
    internal class Rechner
    {
        private double _operand1;
        private double _operand2;
        private double _ergebnis;
        private string _operator1;
        private bool _gueltig;

        public double setOperand1(double operand1)
        {
            this._operand1 = operand1;
            return this._operand1;

        }
        public double setOperand2(double operand2)
        {
            this._operand2 = operand2;
            return this._operand2;
        }
        public string setOperator(string operator1)
        {
            this._operator1 = operator1;
            return this._operator1;
        }

        public void berechne()
        {
            switch (this._operator1)
            {

                case "1":
                    _ergebnis = _operand1 + _operand2;
                    break;

                case "2":
                    _ergebnis = _operand1 - _operand2;
                    break;

                case "3":
                    _ergebnis = _operand1 * _operand2;
                    break;

                case "4":
                    _ergebnis = _operand1 / _operand2;
                    break;

                case "5":
                    Console.WriteLine("Programm beendet");
                    break;

                default:
                    Console.WriteLine("Ungültige Angabe");
                    break;
            }



        }
        public void gibErgebnisAus()
        {
            Console.WriteLine("Ergebnis:");
            Console.WriteLine(_ergebnis);
        }

    }
}

