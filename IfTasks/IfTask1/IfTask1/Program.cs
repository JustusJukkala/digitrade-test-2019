﻿using System;

namespace IfTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää käyttäjän syöttämästä luvusta, onko se positiivine vai negatiivinen");
            Console.WriteLine("Syötä kokonaisluku: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if(userInputNumber == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} on nolla!");
            }
            else
            {
                if(userInputNumber > 0)
                {
                    Console.WriteLine($"Luku {userInputNumber} on positiivinen!");
                }
                else
                {
                    Console.WriteLine($"Luku {userInputNumber} on negatiivinen!");
                }
            }
        }
    }
}
