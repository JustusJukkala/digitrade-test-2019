using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample"); // Tulostaa näytölle vakio viestin ReadWriteExample
            Console.Write("Moi, Kirjoita nimesi: "); // Tlostaa näytölle vakio viestin
            string userInput = Console.ReadLine(); // Luetaan käyttäjän syöttämät merkit niin pitkään kunnes painetaan Enter 
            // sijoitetaan merkit merkkijonomuuttujaan userInput
            Console.WriteLine("-------------------"); //  Tulostaa näytölle vakioviestin
            Console.WriteLine("Moi " + userInput + "!"); // Tulostaa näytölle vakioviestin ja muuttujan userInput arvon
            Console.WriteLine("Moi {0}!", userInput);
            Console.WriteLine($"Moi {userInput}!"); // Tulostuksen muotoilu ja muuttujien käyttö tulostuksen yhteydessä $-merkin avulla = string.Format()
            
        }
    }
}
