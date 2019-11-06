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

        /// <summary>
        /// Compare two numbers and return min number.
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>min number</returns>
        static int GetMinNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber < secondNumber) //return firstNumber < secondNumber? firstNumber: secondNumber;
            {
                return firstNumber;
            }
            else
            {
                return secondNumber;
            }
        }

        /// <summary>
        /// Compare two numbers and return max number
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns>max number</returns>
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
