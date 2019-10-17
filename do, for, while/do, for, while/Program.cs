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
            int fact = 1;
            int n = userInput;


            //for (int n = 0; n < userInput; n++)
            if (n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            else
            {
                while (n > 0)
                {
                    fact = fact * n;
                    n--;
                }
            }
            //Tulostaa vastauksen näytölle
            Console.WriteLine("Vastaus: " + fact);
        }
    }
}
