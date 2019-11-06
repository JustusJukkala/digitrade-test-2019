using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää kahdesta luvusta pienemmän minimi -funktion avulla");
            Console.Write("1. Numero: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("2. Numero: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine($"Luku {GetMinNumber(x,y)} on pienempi kuin {GetMaxNumber(x,y)}");
        }

        static int GetMinNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        static int GetMaxNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber > secondNumber)
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }
    }
}
