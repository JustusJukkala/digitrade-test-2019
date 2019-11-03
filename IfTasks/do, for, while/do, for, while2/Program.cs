using System;

namespace do__for__while2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N lukujen summan");
            Console.WriteLine("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("FOR----------------------------");
            for (int i = 0; i < userInput; i++) // for versio, index pitää lähteä 0
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("WHILE--------------------------");

            int j = 0; // Laskurin määritys
            while (j < userInput) // while versio. Silmukan ehto. Silmukkaa tehdään niin pitkään kunnes se on epätosi
            {
                Console.WriteLine(j + 1); // j++; <- Laskurin kasvatus yhdellä
                j++; // Console.WriteLine(j); , Tulostus
            }

            Console.WriteLine("WHILE ikiluuppi----------------");

            int k = 0; // Laskurin määritys
            while (true) // while versio. Silmukan ehto. Silmukkaa tehdään niin pitkään kunnes se on epätosi
            {
                k++; //Laskuri kasvatus yhdellä
                Console.WriteLine(k); // Tulostus
                if (k >= userInput) //Ehto silmukan lopetukselle
                    break;
            }

            Console.WriteLine("DO-WHILE-----------------------");

            int n = 0;
            do
            {
                n++;
                Console.WriteLine(n);
            } while (n<userInput);

            Console.WriteLine("Ohjelman suoritus on päättynyt!");
        }
    }
}
