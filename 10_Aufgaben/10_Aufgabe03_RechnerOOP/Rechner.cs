namespace _05AufgabeRechnerOOP;

public class Rechner
{
    //Felder: Zustand der Klasse
    private string _operator;
    private double _operand1;
    private double _operand2;
    private double _ergebnis;
    private bool _gueltig;
    private DateTime _zeitstempel;

    //Methoden: Verhalten der Klasse
    public void SetOperand1(double op)
    {
        _operand1 = op;
    }
    public void SetOperand2(double op)
    {
        // Überprüfen, ob die Division durch Null vorliegt
        if (_operator == "/" && op == 0)
            _gueltig = false;

        else
            _gueltig = true;

        _operand2 = op;
    }

    public void SetOperator(string op)
    {

        _operator = op;
        if (_operator != "/")
        {
            _gueltig = true;
        }
    }
    public void Berechnen()
    {
        if (_gueltig == false)
        {
            Console.WriteLine("Ungültige Eingabe. Division durch 0 nicht erlaubt.");
            return;
        }



        switch (_operator)
        {
            case "+":
                _ergebnis = _operand1 + _operand2;
                break;
            case "-":
                _ergebnis = _operand1 - _operand2;
                break;
            case "*":
                _ergebnis = _operand1 * _operand2;
                break;
            case "/":
                if (_operand2 != 0)
                {
                    _ergebnis = _operand1 / _operand2;
                }
                else
                {
                    Console.WriteLine("Division durch Null ist nicht erlaubt.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Ungültiger Operator.");
                return;
        }
        _zeitstempel = DateTime.Now; // Zeitstempel setzen
    }

    public void GibAusgabe()
    {
        if (_gueltig)
        {
            Console.WriteLine($"Ergebnis: {_ergebnis}");
            Console.WriteLine($"Berechnung durchgeführt am: {_zeitstempel}");
        }
        else
        {
            Console.WriteLine("Ungültige Berechnung. Bitte überprüfen Sie Ihre Eingaben. (Division durch Null nicht erlaubt)");
        }
    }
}
