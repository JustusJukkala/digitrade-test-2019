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
            bool isOK = IsValidID(idNumber, 'T');
            PrintResult(isOK);

        }

        static int InputParser(string stringParser)
        {
            // Luetaan 
            //string result = stringParser.Substring(0, 6);

            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);
            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber, char userInputChkMark)
        {
            string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";

            int modChecker = idNumber % 31;

            // Vertaile onko käyttäjän syöttämä viimeinen merkki sama kuin laskettu
            if (chkMark[modChecker] == userInputChkMark)
                return true;
            else
                return false;
            //return chkMark[modChecker] == userInputChkMark;
        }

        static void PrintResult(bool isValidID)
        {
            if(isValidID)
                Console.WriteLine("Sotu on oikein!");
            else
                Console.WriteLine("Sotu on väärin!");
        }

    }
}
