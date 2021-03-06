﻿using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa syötetyn numeron mukaisen määrän tähtiä.");
            Console.WriteLine("Syötä kokonaisluku: ");
            int userInput = int.Parse(Console.ReadLine());
            if (IsValidNumber(userInput))
            {
                string strStars = GenerateAmountOfStars(userInput);
                Console.WriteLine(strStars);
                //Console.WriteLine(GenerateAmountOfStars(userInput);
            }
            else
            {
                Console.WriteLine($"Numero {userInput} ei ole sallittu luku!");
            }
            
        }

        static bool IsValidNumber(int userInput)
        {
            return userInput > 0;
            /*
            if (userInput > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            */
            //return false;
        }
        /// <summary>
        /// Ohjelma generoi parametrin määrän tähtiä
        /// </summary>
        /// <param name="starCounter"></param>
        /// <returns></returns>
        static string GenerateAmountOfStars(int starCounter)
        {
            string stars = "";
            for (int i = 0; i < starCounter; i++)
            {
                stars = stars + "*";
                //stars += "*"; vaihtoehtoinen versio
            }
            return stars;
        }
    }
}
