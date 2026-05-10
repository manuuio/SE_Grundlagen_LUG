namespace RechnerProgramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            Rechner rechner = new Rechner();

            do
            {
                Console.Clear();
                Console.WriteLine("****** Menü ******:");
                Console.WriteLine("\tOption 1: Add");
                Console.WriteLine("\tOption 2: Sub");
                Console.WriteLine("\tOption 3: Mult");
                Console.WriteLine("\tOption 4: Div");
                Console.WriteLine("\tOption 5: Finish Diese");
                eingabe = Console.ReadLine() ?? "";

                if (eingabe == "1")
                {
                    Console.WriteLine("Gib Operand 1 ein");
                    double operand1 = double.Parse(Console.ReadLine() ?? "");
                    rechner.setOperand1(operand1);

                    Console.WriteLine("Gib Operand 2 ein");
                    double operand2 = double.Parse(Console.ReadLine() ?? "");
                    rechner.setOperand2(operand2);

                    rechner.setOperator(eingabe);

                    rechner.berechne();

                    rechner.gibErgebnisAus();
                    Console.ReadLine();


                }


            }
            while (eingabe != "5");

        }
    }
}

