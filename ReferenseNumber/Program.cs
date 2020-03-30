using System;

namespace ReferenseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Program checks Referensenumber rightnes.");
            //User interface
            char userChoise;
            
            do
            {
                Console.Clear();
                userChoise = UserInterface();
                switch (userChoise)
                {
                    case 'C':
                        ReferenseNumberChecker();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 'N':
                        ReferenseNumberCreator();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 'M':
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 'X':
                        break;

                    default:

                        Console.WriteLine("\nCheck what you Presse!  Continue program driving");
                        Console.ReadKey();
                        break;
                }
                Console.ReadLine();
            } while (userChoise != 'X');

        }//End main Program
        static char UserInterface()
        {
            Console.WriteLine("-----\n\nThis program Checks reference number and creates them as many as you want and saves" +
                  " them in 'Referensenumber.txt' file.\n\n-----\n ");
            Console.WriteLine("---Reference number interface---.");
            Console.WriteLine("[C] Checking reference number.");
            Console.WriteLine("[N] Creating new reference number.");
            Console.WriteLine("[X] Closing program.");
            Console.WriteLine("Choose what to do: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static void ReferenseNumberChecker()
        {
            Console.WriteLine($"\nPlease enter referensenumber to check it: ");
            string userInput = InputNumberValidator();
            int summary = 0;
            char lastNumber;
            
            int numberLength = 0;
            numberLength = userInput.Length;
            lastNumber = userInput[numberLength - 1];
            userInput = userInput.Remove(numberLength - 1, 1);

            int n = 3;
            for (int i = userInput.Length - 1; i >= 0; i--) //this for loop sum user input numbers to last
            {


                if (n == 3)
                {
                    summary += int.Parse(userInput[i].ToString()) * 7;
                    n--;
                }
                else if (n == 2)
                {
                    summary += int.Parse(userInput[i].ToString()) * 3;
                    n--;
                }
                else if (n == 1)
                {
                    summary += int.Parse(userInput[i].ToString()) * 1;
                    n = 3;
                }
            }

            Console.WriteLine(summary); // this line was made check if summary is right
            int numbValidator = summary + int.Parse(lastNumber.ToString());

            if (numbValidator % 10 == 0)
            {
                Console.WriteLine($"Your : {userInput}{lastNumber} is correct reference number");
            }
            else
            {
                Console.WriteLine("Referensenumber is Wrong");
            }
            Console.WriteLine(summary + int.Parse(lastNumber.ToString()));
            Console.WriteLine(summary += int.Parse(lastNumber.ToString()) % 10);
            //static bool ReferenseNumberCheck(string inputNumberValue)
            //{
            //    int summary = 0;
            //    char lastNumber;            //userinput is valid referencenumber
            //    int numberLength = 0;
            //    numberLength = inputNumberValue.Length;
            //    lastNumber = inputNumberValue[numberLength - 1];
            //    inputNumberValue = inputNumberValue.Remove(numberLength - 1, 1);


            //    int n = 3;
            //    for (int i = inputNumberValue.Length - 1; i >= 0; i--)  //This loop sums userinput numbers
            //    {                                               //from last to first by 731 rule without 
            //                                                    //original userinput last number
            //        if (n == 3)
            //        {
            //            summary += int.Parse(inputNumberValue[i].ToString()) * 7;
            //            n--;
            //        }
            //        else if (n == 2)
            //        {
            //            summary += int.Parse(inputNumberValue[i].ToString()) * 3;
            //            n--;
            //        }
            //        else if (n == 1)
            //        {
            //            summary += int.Parse(inputNumberValue[i].ToString()) * 1;
            //            n = 3;
            //        }
            //    }
            //    // Console.WriteLine(summary); this line was to check if summary is right
            //    int numbValidator = summary + int.Parse(lastNumber.ToString());
            //    if (numbValidator % 10 == 0)
            //    {
            //        return true;
            //    }
            //    else
            //    {
            //        return false;
            //    }

            //}
        }
        static string InputNumberValidator()
        {
            string input = "";
            int inputNumber = 0;
            do
            {
                Console.WriteLine("Enter referense, witch have  only numbers and is 4-20 marks long.");
                Console.Write("Enter your Number:");
                input = Console.ReadLine().Replace(" ", "").Replace("-", "");
            }
            while (input.Length <= 3 || input.Length >= 21 || !Int32.TryParse(input, out inputNumber) || inputNumber < 0);
            return input;
        }
        static void ReferenseNumberCreator()
        {
            string userInput = CreatorInputNumberValidator();

            while (userInput.Length <= 2 || userInput.Length >= 20);
            int sum = 0;
            int[] multiplier = new int[] { 7, 3, 1 };
            int[] referenseArray = new int[userInput.Length];

            for (int i = 0; i < userInput.Length; i++)
            {
                referenseArray[i] = int.Parse(userInput[i].ToString());
            }

            for (int i = 0; i < referenseArray.Length; i++)
            {
                sum += referenseArray[referenseArray.Length - 1 - i] * multiplier[i % 3];
            }
            int checkNumber = 10 - (sum % 10);
            if (checkNumber == 10)
            {
                checkNumber = 0;
            }
            Console.WriteLine($"Your input number is : {userInput}");

            string referenseNumberOutput = userInput+ checkNumber;
            for (int i = 1; i < referenseNumberOutput.Length; i++)
            {
                if (i % 5 == 0)
                {
                    referenseNumberOutput = referenseNumberOutput.Insert(i, " ");
                }
            }
            Console.WriteLine($"New referense number is : {referenseNumberOutput}");
        }
        static string CreatorInputNumberValidator()
        {
            string input = "";
            int inputNumber = 0;

            do
            {
                Console.WriteLine("Enter the first 3 to 19 characters of the reference number.");

                input = Console.ReadLine().Replace(" ", "").Replace("-", "");
            }
            while (input.Length <= 2 || input.Length >= 21 || !Int32.TryParse(input, out inputNumber) || inputNumber < 0);
            return input;
        }
    }
}
