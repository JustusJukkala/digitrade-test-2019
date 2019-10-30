using System;

namespace LoopTask4point1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tulostaa kokonaisluvut 1-10 ja niiden neliöjuuret");

            Console.WriteLine("Luku\tNeliöjuuri");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{i + 1}\t{Math.Sqrt(i + 1)}");
            }
        }
    }
}
