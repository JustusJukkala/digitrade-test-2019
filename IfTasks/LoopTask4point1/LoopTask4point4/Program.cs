using System;

namespace LoopTask4point4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo annetun heittokertojen klaavojen ja kruunujen määrän.");
            Random rnd = new Random();
            int userInput = int.Parse(Console.ReadLine());
            int countHeads = 0;
            int countTails = 0;
            for (int i = 0; i < userInput; i++)
            {
                rnd.Next(0, 2);
                const int V = 0;
                if (rnd = V)
                {
                    countHeads;
                }
                else
                {
                    countTails;
                }
            }
            Console.WriteLine($"rahaa on heitetty {userInput}");
            Console.WriteLine($"klaavoja tuli {countHeads} ja kruunuja {countTails}");
        }
    }
}
