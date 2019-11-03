using System;

namespace do__for__while4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen. Myös negatiiviset luvut.");
            Console.WriteLine("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;
            int k = -1;

            if (userInput < 0)
            {
                for (int i = 0; i < userInput; i++)
                {
                    sumOfNumbers = sumOfNumbers + (i + 1) * k;
                }

                Console.WriteLine($"Vastaus: {sumOfNumbers}");
            }
            else
            {
                // Ohjelma logiikka, silmukka
                for (int i = 0; i < userInput; i++)
                {
                    sumOfNumbers = sumOfNumbers + (i + 1);
                }

                Console.WriteLine($"Vastaus: {sumOfNumbers}");
            }
        }
    }
}
