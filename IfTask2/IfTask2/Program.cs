using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää Maatalousnäyttelyn lipunhinnan alennuksen");
            Console.WriteLine("Lipun hinta ilman alennusta 16€");
            Console.WriteLine("Syötä ikä"); // kysytään ikää, jonka avulla lasketaan ikään liittyvä alennus

            int age = int.Parse(Console.ReadLine());
            // pitää viellä kysyä että onko varusmies, opiskelia, opiskelia mtk jäsenyydellä, mtk jäsen tai ei jäsenyyttä
            int ticketPrice = 16;
            double discount = 0;

            if (age < 7) // alle 7 vuotiaiden lapsien alennus
            {
                discount = 1;
                Console.WriteLine($"Hinta on {ticketPrice - (ticketPrice*discount)}!");
            }
            else if (age > 65) // Eläkeläisten alennus

            {
                discount = 0.5;
                Console.WriteLine($"Hinta on {ticketPrice - (ticketPrice * discount)}!");
            }
            else if (age < 7 || age > 65) // muitten kuin lapsien ja eläkeläisten hinta
            {
                discount = 0;
                Console.WriteLine($"Hinta on {ticketPrice - (ticketPrice * discount)}!");
            }
        }
    }
}
