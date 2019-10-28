using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo kumpi annetuista numeroista on pienempi");
            Console.WriteLine("1. Numero: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("2. Numero: ");
            int b = int.Parse(Console.ReadLine());
        }

        static void Minimum(int x, int y)
        {
            if (x > y)
            {
                Console.WriteLine($"Luku {y} on pienempi kuin luku {x} ");
            }
            else
            {
                Console.WriteLine($"Luku {x} on pienempi kuin luku {y} ");
            }
        }
    }
}
