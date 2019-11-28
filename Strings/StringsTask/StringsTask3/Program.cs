using System;

namespace StringsTask3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee antamastasi syötteestä l-kirjaimien määrän");
            string message = Console.ReadLine();
            int countL = 0;
            for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'l')
                {
                    countL++;
                }
            }
            Console.WriteLine($"Syötteestä {message} löytyi {countL} l-kirjainta.");
        }
    }
}
