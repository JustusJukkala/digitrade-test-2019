﻿using System;

namespace StringsExampleHelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkkijononkäsittely esimerkki");
            string message = "Hello World!";

            // Tulostetaan message -muuttujan merkit yksitellen näytölle
            Console.WriteLine($"{message}:ssä on {message.Length} merkkiä.");

            for (int i = 0; i < message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}
