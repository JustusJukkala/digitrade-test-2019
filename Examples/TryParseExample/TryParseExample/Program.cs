using System;

namespace TryParseExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("TryParse Esimerkki");
            string userInput = Console.ReadLine();

            // tarkastetaan onko annettu syöte luku
            bool isNumber = int.TryParse(userInput, out int userNumber);

            if (isNumber)
            {
                Console.WriteLine($"Syöte '{userInput}' on luku {userNumber}");
            }
            else
            {
                Console.WriteLine($"Syöte '{userInput}' on merkkijono ja muuttujan userNumber arvo on {userNumber}");
            }
        }
    }
}
