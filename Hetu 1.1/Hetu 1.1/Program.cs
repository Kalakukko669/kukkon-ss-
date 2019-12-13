using System;

namespace Hetu_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program checks Hetu rightnes.");
            string userInput = "070496-161P";

            userInput=RemoveSpaces(userInput);
            if (IsValidLenght(userInput))
            {
                int idNumber = InputParser(userInput);
                char getLastChar = GetUserInputChkmark(userInput);
                bool isOk = IsValidID(idNumber, getLastChar);
                PrintResult(isOk);

            } 
        }
        static bool IsValidDate(string userInput)
        {
            //"070496-161P"
            bool result = false;
            //

            return result;
        }

        static bool IsValidLenght(string userInput)
        {
            return userInput.Length == 11;

            
        }

        static string RemoveSpaces(string userInput)
        {
            string result = userInput.Replace(" ","");
            return result;
        }

        static char GetUserInputChkmark(string userInput)
        {
            return userInput[userInput.Length - 1];
        }

        static int InputParser(string stringParser)   
        {

            string removed = stringParser.Remove(10, 1);
            removed = removed.Remove(6, 1);
            return int.Parse(removed);
        }

        static bool IsValidID(int idNumber, char userInputChkMark)
        {
            string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int modChecker = idNumber % 31;

            if (chkMark[modChecker] == userInputChkMark)
                return true;
            else
                return false;

        }
        static void PrintResult(bool isValidID)
        {
            if (isValidID)
                Console.WriteLine("Sotu on oikein!");
            else
                Console.WriteLine("Sotu on väärin!");
        }
    }
}
