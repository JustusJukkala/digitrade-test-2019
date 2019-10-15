using System;

namespace do__for__while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tulostaa antamasi luvun kertoman!");
            Console.WriteLine("syötä luku!");
            {
                int i = int.Parse(Console.ReadLine()), sum = 0;
                while (i <= 5)
                {
                    sum += i;
                    i++;
                }
                Console.WriteLine("Sum = {0}", sum);
            }
        }
    }
}
