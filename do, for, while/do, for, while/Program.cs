using System;

namespace do__for__while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa antamasi luvun kertoman!");
            Console.WriteLine("syötä luku!");
            int userInput = int.Parse(Console.ReadLine());

            for (int n = 0; n < userInput; n++)
            {
                Console.WriteLine
            }
            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            else
            {
                while (n > 0)
                {
                    fact = fact * n
                    n = n - 1;
                }
            }
            //Tulostaa vastauksen näytölle
            Console.WriteLine("Vastaus: " + fact);
        }
    }
}
