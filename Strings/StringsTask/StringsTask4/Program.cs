using System;

namespace StringsTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma kertoo, että onko antamasi sana tai lause palidromi.");
            string message = Console.ReadLine();
            message = message.Replace(" ", ""); // Poistetaan välilyönnit, jotta ohjelman on helpompi käsitellä lausetta/sanaa.
            int deliver = 0;
            int receive = message.Length - 1;
            bool check = true; // bool:n avulla pystytään tarkistamaan, että  lause/sana on molemminpäin sama.

            for (int i = 0; i < message.Length - 1; i++) // Tarkistaa, että lause/sana on sama oikein ja väärin päin.
            {
                if (message[deliver] == message[receive])
                {
                    deliver++;
                    receive--;
                }
                else
                    check = false;
            }
            if (check == true)
            {
                message = message.ToUpper();
                Console.WriteLine($"Antamasi syöte {message} oli palindromi"); // Tulostaa tämän jos lause/sana on palindromi
            }
            else
            {
                message = message.ToUpper();
                Console.WriteLine($"Antamasi syöte {message} ei ollut palindromi"); // Tulostaa tämän jos lause/sana ei ole palindromi
            }
        }
    }
}
