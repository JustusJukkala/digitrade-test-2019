using System;

namespace IfTask3
{ 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko negatiininen vai positiivinen ja onko luku parillinen vai pariton!");
            Console.WriteLine("Syötä kokonaisluku: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} on nolla!");
            }
            else
            {
                if (userInputNumber < 0)
                {
                    Console.Write($"Luku {userInputNumber} on negatiivinen");
                }
                else
                {
                    Console.Write($"Luku {userInputNumber} on positiivinen");
                }
                if (userInputNumber % 2 == 0)
                {
                    Console.WriteLine(" ja parillinen!");
                }
                else
                {
                    Console.WriteLine(" ja pariton!");
                }
            }
            }
        }
    }
