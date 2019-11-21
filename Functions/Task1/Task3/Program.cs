using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            int minValue = -10;
            int maxValue = 10;
            Console.WriteLine($"Ohjelma tarkistaa, että onko annettu syöte luku ja onko se väliltä {minValue}...{maxValue}");
            Console.Write("Syötä luku: ");
            string userInput = Console.ReadLine();
            bool isValidInput = int.TryParse(userInput, out int userNumber);
            if (isValidInput)
            {
                // Tarkastetaan syötteen luku väli
                if (IsValidNumber(minValue,maxValue,userNumber))
                {
                    Console.WriteLine($"Syötetty Luku {userNumber} oli annetulla lukualuella {minValue}...{maxValue}");
                }
                else
                {
                    Console.WriteLine($"Syötetty luku {userNumber} ei ollut annetulla lukualueella {minValue}...{maxValue}");
                }
            }
            else
            {
                Console.WriteLine("Syötä lukuja, kirjaimien sijasta");
                // Syöte ei ollut luku
            }

        }

        static bool IsValidNumber(int minValue, int maxValue, int userNumber)
        {
            return userNumber > minValue && userNumber < maxValue;

            //if(userNumber > minValue && userNumber < maxValue)
            //{

            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }
    }
}
