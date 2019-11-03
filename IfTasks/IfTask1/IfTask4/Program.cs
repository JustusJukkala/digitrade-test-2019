using System;

namespace IfTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lajittelee luvut nousevaan järjestykseen!");
            // Tietojen kysely
            Console.Write("Syötä 1. luku: ");
            int x = int.Parse(Console.ReadLine());
            
            Console.Write("Syötä 2. luku: ");
            int y = int.Parse(Console.ReadLine());

            Console.Write("Syötä 3. luku: ");
            int z = int.Parse(Console.ReadLine());


            // Logiikka, jolla ratkaistaan ongelma
            if ((x > y) && (x > z))
                //ehtojen asetus
            {
                if (y > z)
                //ehdolle vielä lisä ehto
                {
                    Console.WriteLine($" {x} , {y} , {z} ");
                }

                else if (z > y)
                //Jos z on isompi kuin y
                {
                    Console.WriteLine($" {x} , {z} , {y} ");
                }

            }
            else if ((y > x) && (y > z))
                //asettaa ehdot
            {
                if (x > z)
                    //ehdon ehto
                {
                    Console.WriteLine($" {y} , {x} , {z} ");
                    //tulostaa tämän jos ehdot toteutuvat
                }

                else if (z > x)
                    //jos z on isompi kuin x
                {
                    Console.WriteLine($" {y} , {z} , {x} ");
                    //tulostaa tämän muussa tapauksessa
                }
            }

        }
    }
}
