using System;
using System.IO;

namespace HarjoitusTyo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string input = string.Empty;//tämä pitää määrittää tyhjäksi, että inputit toimii switch casessa

            char userChoice;//Tämä kutsuu käyttöliittymää

            do
            {
                Console.Clear();//tyhjentä konsolin
                userChoice = UserInterface();
                switch (userChoice)
                {
                    case '1':
                        try
                        {

                        }
                        catch
                        {

                        }
                        break;
                    case '2':
                        try
                        {

                        }
                        catch
                        {

                        }
                        break;
                    case '3':
                        try
                        {

                        }
                        catch
                        {

                        }
                        break;
                    case 'X':
                        break;

                    default:
                        Console.WriteLine("Tarkista syöttämäsi tiedot");
                        Console.ReadLine();
                        break;
                }
            } while (userChoice != 'X');

        }//Pääohjelma loppuu tähän

        static char UserInterface()
        {
            Console.WriteLine("Ohjelma tarkistaa viitenumeron todellisuuden ja luo yhden tai useamman viite numeron");
            Console.WriteLine("Käyttöliittymä");
            Console.WriteLine("[1] Tarkista viitenumeron oikeillisuus");
            Console.WriteLine("[2] Luo uusi viitenumero");
            Console.WriteLine("[3] Luo useampi viitenumero");
            Console.WriteLine("[X] Lopeta ohjelman suoritus");
            Console.Write("Mitä haluat tehdä: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

    }
}
