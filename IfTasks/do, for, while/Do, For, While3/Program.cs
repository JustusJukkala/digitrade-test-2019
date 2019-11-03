using System;

namespace Do__For__While3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N:n ensimmäisen parittoman ja parillisen lukujen summan.");
            Console.WriteLine("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;
            // muuttujat
            for(int i = 0;i <= userInput; i++)
            {
                if (i % 2 == 0)
                {
                    evenSum = evenSum + i;
                }
                else
                {
                    oddSum = oddSum + i;
                }
            }
            Console.WriteLine($"Parillisten summa = {evenSum}\n" +
                $"Parittomien summa = {oddSum}");

            /*
            Epäonnistunut versio
            Console.WriteLine("Ohjelma laskee parittomien summan ja parillisten summan");
            Console.WriteLine("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());

            if (userInput % 2 == 0)
            {
                int j = 0; // Laskurin määritys
                while (j < userInput) // while versio. Silmukan ehto. Silmukkaa tehdään niin pitkään kunnes se on epätosi
                {
                    j++;
                    Console.WriteLine(j);
                }
            }
            else userInput % 2 == 1
            {
                int i = 0;
                while (i < userInput)
                {
                    i++;
                    Console.WriteLine(i);
                }
            }
            */
        }
    }
}
