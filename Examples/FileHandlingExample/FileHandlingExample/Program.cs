using System;
using System.IO;

namespace FileHandlingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tiedoston kirjoitus ja luku esimerkki.");

            string path = @"c:\tmp\MyTest.txt"; // uusi versio
            // string path = "c:\\temp\\MyTest.txt"; vanha versio
            WriteToFile(path);
            ReadFile(path);
        }// End Main Program

        static void WriteToFile(string path)
        {
            DateTime currentTime = DateTime.Now;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{currentTime} ------------");
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
                sw.WriteLine("Tässä Jounin rivi");
            }
        }

        static void ReadFile(string path)
        {
            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }

    }
}
