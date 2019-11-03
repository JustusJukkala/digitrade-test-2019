using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku pariton vai parillinen!");
            Console.WriteLine("Syötä Kokonaisluku: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber % 2 == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} on parillinen!");
            }
            else
            {
                Console.WriteLine($"Luku {userInputNumber} on pariton!");
            }
        }
    }
}
