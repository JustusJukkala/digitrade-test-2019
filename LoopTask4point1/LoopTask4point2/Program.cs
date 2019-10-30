using System;

namespace LoopTask4point2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa kertotaulun luvuille 1-9");
            for(int i = 1; i < 10; i++)
            {
                for(int j = 1; j < 10; j++)
                {
                    Console.WriteLine($"{i} x {j} = {i*j}");
                }
            }
        }
    }
}
