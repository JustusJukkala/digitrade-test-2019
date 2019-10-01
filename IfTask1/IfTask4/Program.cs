using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen!");
            Console.WriteLine("Syötä kolme kokonaislukua: ")
            int userInputNumberx = int.Parse(Console.WriteLine());
            int userInputNumbery = int.Parse(Console.WriteLine());
            int userInputNumberz = int.Parse(Console.WriteLine());

            if (userInputNumberx > userInputNumbery)
            {
                Console.WriteLine($"Luku {userInputNumberx} on suurempi kuin Luku{userInputNumbery}");
            }
        }
    }
}
