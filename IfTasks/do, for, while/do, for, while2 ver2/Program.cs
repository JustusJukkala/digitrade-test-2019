﻿using System;

namespace do__for__while2_ver2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N ensimmäistä lukua yhteen.");
            Console.WriteLine("Syötä luku: ");
            int userInput = int.Parse(Console.ReadLine());
            int sumOfNumbers = 0;

            if (userInput < 0)
            {
                Console.WriteLine("Virheellinen syöte");
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
