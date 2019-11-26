using System;

namespace StringsTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma ilmoittaa syötettyjen merkkien lukumäärän");
            string message = Console.ReadLine();
            Console.WriteLine($"{message}:ssä on {message.Length} merkkiä.");
        }
    }
}
