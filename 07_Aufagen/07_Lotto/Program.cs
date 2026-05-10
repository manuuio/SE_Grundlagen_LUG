namespace _07_Lotto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] userNumbers = new int[6];
            int[] lottoNumbers = new int[6];
            Random rand = new Random();

            for (int i = 0; i < 6; i++)
            {
                Console.Write($"Gib Zahl {i + 1} (1-49) ein: ");
                int number = Convert.ToInt32(Console.ReadLine());

                bool exists = false;
                for (int j = 0; j < i; j++)
                {
                    if (userNumbers[j] == number)
                    {
                        exists = true;
                    }
                }

                if (exists || number < 1 || number > 49)
                {
                    Console.WriteLine("Ungültig oder doppelt! Versuch nochmal.");
                    i--;
                }
                else
                {
                    userNumbers[i] = number;
                }
            }

            for (int i = 0; i < 6; i++)
            {
                int number = rand.Next(1, 50);

                bool exists = false;
                for (int j = 0; j < i; j++)
                {
                    if (lottoNumbers[j] == number)
                    {
                        exists = true;
                    }
                }

                if (exists)
                {
                    i--;
                }
                else
                {
                    lottoNumbers[i] = number;
                }
            }

            int correct = 0;

            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (userNumbers[i] == lottoNumbers[j])
                    {
                        correct++;
                    }
                }
            }

            Console.WriteLine("\nDeine Zahlen:");
            foreach (int n in userNumbers)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine("\n\nGezogene Zahlen:");
            foreach (int n in lottoNumbers)
            {
                Console.Write(n + " ");
            }

            Console.WriteLine($"\n\nRichtige: {correct}");
        }
    }
}
