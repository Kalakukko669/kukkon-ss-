using System;
using System.Text;
using System.Collections.Generic;
using System.IO;




namespace ReferenseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Program checks Referensenumber rightness.");
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
                        ManyReferenceNumberCreating();

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

        } //End main Program

        static char UserInterface()
        {
            Console.WriteLine(
                "-----\n\nThis program Checks reference number and creates them as many as you want and saves" +
                " one of them in 'referensenumbers.txt' file.\n\n-----\n ");
            Console.WriteLine("---Reference number interface---.");
            Console.WriteLine("[C] Checking reference number.");
            Console.WriteLine("[N] Creating new reference number.");
            Console.WriteLine("[M] Creating many new reference number.");
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
            StringBuilder sb = new StringBuilder();//Created String Builder object and added using System.Text;
            List<String> referenseNumbers = new List<String>();//Created List where referense numbers are aded;
            Random rndm = new Random();//Created Random Number generator;

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
            } while (input.Length <= 3 || input.Length >= 21 || !Int32.TryParse(input, out inputNumber) ||
                     inputNumber < 0);

            return input;
        }

        static void ReferenseNumberCreator()
        {
            string userInput = CreatorInputNumberValidator();

            while (userInput.Length <= 2 || userInput.Length >= 20) ;
            int sum = 0;
            int[] multiplier = new int[] {7, 3, 1};
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

            string referenseNumberOutput = userInput + checkNumber;
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
            } while (input.Length <= 2 || input.Length >= 21 || !Int32.TryParse(input, out inputNumber) ||
                     inputNumber < 0);

            return input;
        }

        static void ManyReferenceNumberCreating()
        {
            
            string userInput;
            int InputAmountReferenseNumbers;
            int lenghtOfRefNumb = 19;
            bool amountTimeManufacturing = true;
            int basePart;
            
            
            StringBuilder sb = new StringBuilder();//Created String Builder object and added using System.Text;
            List<String> referenseNumbers = new List<String>();//Created List where referense numbers are aded;
            Random rndm = new Random();//Created Random Number generator;

            do
            {
                Console.WriteLine(
                    "\nIf you need to read this lines again your entered Reference number first part isn't right. " +
                    "\nEnter the first 3 to 19 characters of the reference number:");

                userInput = Console.ReadLine().Replace(" ", "").Replace("-", "");

            } while ((userInput.Length <= 2 || userInput.Length >= 21 || !Int32.TryParse(userInput, out basePart) ||
                      basePart < 0 ));

           
            lenghtOfRefNumb = lenghtOfRefNumb - userInput.Length;
            Console.Clear();
            do
            {
                Console.WriteLine(
                    "\nIf you need to read this lines again your entered amount Referense Numbers is biger than 1000 or 0 and lesser. " +
                    "\nEnter number bigger than 0 and bigger than 1000:");
                InputAmountReferenseNumbers = Int32.Parse((Console.ReadLine().Replace(" ", "").Replace("-", "")));



            } while ((InputAmountReferenseNumbers< 0 || InputAmountReferenseNumbers >= 1000));

            Console.Clear();
            //testing how i do this

            while (amountTimeManufacturing)
            {
                
                for (int i = 0; InputAmountReferenseNumbers > i; i++)
                {
                    sb.Append(basePart.ToString() + "-");

                    for (int j = 0; lenghtOfRefNumb < j; j++)
                    {
                        sb.Append(rndm.Next(0, 10).ToString());
                    }

                    foreach (String listedReferenses in referenseNumbers)
                    {
                        if (listedReferenses == sb.ToString())
                        {

                            sb.Clear();//Clears All copies 
                            sb.Append(userInput + "-");

                            for (int j = 0; j < lenghtOfRefNumb; j++)
                            {
                                sb.Append(rndm.Next(0, 10).ToString());
                            }

                        }

                    }

                    referenseNumbers.Add(sb.ToString());
                    sb.Clear();

                }






                amountTimeManufacturing = false;
            }
              


            foreach (String allreferenseNumbers in referenseNumbers)
            {


                Console.WriteLine(allreferenseNumbers);

                using (System.IO.StreamWriter file = new System.IO.StreamWriter(
                    "\\jytky kone private key\\dev\\jytkykoodi\\kukkon-ss-\\ReferenseNumber\\ referensenumbers.txt"))
                {
                    file.WriteLine(allreferenseNumbers);
                }

               


            }


        }

    }
}