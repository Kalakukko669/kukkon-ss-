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
                userChoise = UserInterface();//Kutsutaan käyttöliittymä funktiota
                switch (userChoise)
                {
                    case 'C':
                        //ReferenseNumberChecker();//Calling method ReferenseNumberChercke

                        string inputnumbervalue = Console.ReadLine();
                        if (ReferenseNumberCheck(inputnumbervalue) == true)
                        {
                            Console.WriteLine($"Your entered input value{inputnumbervalue} is right");
                        }
                        else
                        {
                            Console.WriteLine($"Your entere referense numner{inputnumbervalue} is wrong");
                        }

                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        break;
                    case 'N':
                        //ReferenseNumberCreator();//Calling metod Referense NumberCreator
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
                  " them in 'Referencenumber.txt' file.\n\n-----\n ");
            Console.WriteLine("---Reference number interface---.");
            Console.WriteLine("[C] Checking reference number.");
            Console.WriteLine("[N] Creating new reference number.");
            Console.WriteLine("[X] Closing program.");
            Console.WriteLine("Choose what to do: ");
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

                //static void ReferenseNumberChecker()
                //{
                //    Console.WriteLine("Please enter referensenumber to check it: ");
                //    string userInput = Console.ReadLine();
                //    int summary = 0;
                //    char lastNumber;
                //    char valueMark;
                //    int numberLength = 0;                                                        
                //    numberLength = userInput.Length;
                //    lastNumber = userInput[numberLength - 1];
                //    userInput = userInput.Remove(numberLength - 1, 1); 
            
                //    int n = 3;
                //    for (int i = userInput.Length-1; i>=0; i--)//this for loop sum user input numbers to last
                //    {
               
                
                //        if (n == 3)
                //        {
                //            summary = summary +int.Parse(userInput[i].ToString())  *7;
                //            n--;
                //        }
                //        else if (n == 2)
                //        {
                //            summary = summary + int.Parse(userInput[i].ToString()) * 3;
                //            n--;
                //        }
                //        else if (n == 1)
                //        {
                //            summary = summary + int.Parse(userInput[i].ToString()) * 1;
                //            n = 3;
                //        }
                //    }
                //    Console.WriteLine(summary);// this line was made check if summary is right
                //    int numbValidator = summary + int.Parse(lastNumber.ToString());
                //    if (numbValidator % 10 == 0)
                //    {
                //        Console.WriteLine($"Your : {userInput}{lastNumber} is correct reference number");
                //    }
                //    else
                //    {
                //        Console.WriteLine("Referencenumber is Wrong");
                //    }
            
            
            //Console.WriteLine(summary+int.Parse(lastNumber.ToString()));
            //Console.WriteLine(  summary+=int.Parse(lastNumber.ToString())%10);
           
    
        
        static bool ReferenseNumberCheck(string inputnumbervalue)
        {
            int summary = 0;
            char lastNumber;                //userinput is valid referencenumber
            int numberLength = 0;
            numberLength = inputnumbervalue.Length;
            lastNumber = inputnumbervalue[numberLength - 1];
            inputnumbervalue = inputnumbervalue.Remove(numberLength - 1, 1);


            int n = 3;
            for (int i = inputnumbervalue.Length - 1; i >= 0; i--)  //This loop sums userinput numbers
            {                                               //from last to first by 731 rule without 
                                                            //original userinput last number
                if (n == 3)
                {
                    summary = summary + int.Parse(inputnumbervalue[i].ToString()) * 7;
                    n--;
                }
                else if (n == 2)
                {
                    summary = summary + int.Parse(inputnumbervalue[i].ToString()) * 3;
                    n--;
                }
                else if (n == 1)
                {
                    summary = summary + int.Parse(inputnumbervalue[i].ToString()) * 1;
                    n = 3;
                }
            }
            // Console.WriteLine(summary); this line was to check if summary is right
            int numbValidator = summary + int.Parse(lastNumber.ToString());
            if (numbValidator % 10 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    
    }
}
