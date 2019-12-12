using System;

namespace SocialSecurityNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma tarkastaa Hetun oikeellisuuden.");
            string userInput = "140296-137U";
            int idNumber = InputParser(userInput);
            IsValidID(idNumber);


        }

        static int InputParser(string stringParser)
        {
            // Luetaan 
            //string result = stringParser.Substring(0, 6);

            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);
            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber)
        {
            string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modChecker = idNumber % 31;

            Console.WriteLine(chkMark[modChecker]);
            return true;
        }
    }
}
