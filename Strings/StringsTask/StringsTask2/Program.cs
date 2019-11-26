using System;

namespace StringsTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma muuttaa syötetystä tekstistä e merkit @-merkeiksi.");
            string message = Console.ReadLine();
            Console.WriteLine($"{message}:sta tulee {message.Replace('e', '@')}");
        }
    }
}
