using System;

namespace ArrayExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma Tulostaa 20 lukua -50 ja 50 väliltä");
            Console.WriteLine("Kuinka monta lukua arvotaan? ");
            int size = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[size]; // Määritetään taulukko ja sen koko.
            arrayNumbers = SetRandomNumbers(size); // Kerrotaan kuinka monta satunnaislukua halutaan
            PrintArray(arrayNumbers);

            
            /*
            for (int i = 0; i < arrayNumbers.Length; i++) // Toisto silmukka toistaa itseänsä niin pitkään kunnes i on 20 tai
            {
                Console.WriteLine(arrayNumbers[i]);
            }
            */
        }

        /// <summary>
        /// Ali-ohjelma, joka palauttaa satunnais lukuja
        /// Funktio arpoo halutun määrän lukuja taulukkoon, jonka k... 
        /// lenght = taulukon koko
        /// opettajan esimerkissä
        /// minValue = alaraja
        /// maxValue = yläraja
        /// </summary>
        /// <param name="length"></param>
        /// <returns></returns>
        static int[] SetRandomNumbers(int length)
        {
            int[] numbers = new int[length];
            Random rnd = new Random();

            for(int i = 0; i < length; i++)
            {
                numbers[i] = rnd.Next(-50, 51); // Määritetään arvottujen lukujen väli
            }
            
            return numbers;
        }
        static void PrintArray(int[] table)
        {
            Console.WriteLine("--------------");
            for (int i = 0; i < table.Length; i++)
            {
                Console.WriteLine($"{i+1}. {table[i]}");
            }
        }
    }
}
