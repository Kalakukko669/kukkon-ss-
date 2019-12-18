using System;

namespace Hetu_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Program checks Hetu rightnes.");
            char userChoise;
            do
            {
                Console.Clear();
                userChoise= UserInterface();//Kutsutaan käyttöliittymä funktiota
                switch (userChoise)
                {
                    case 'T':
                        SSNChecker();//Kutsutaan Sotun tarkastus funktiota
                        break;
                    case 'U':
                        SSNCreator();//Kutsutaan Sotun luonti funktiota
                        break;
                    case 'X':
                        break;

                    default:

                        Console.WriteLine("\nTarkasta mitä painoit! Enter jatkaa ohjelman suoritusta");
                        Console.ReadKey();
                        break;

                      
                }
                Console.ReadLine();
            }while (userChoise!='X');
           
        }
        static void SSNCreator()
        {
            Console.WriteLine("\nAnna tarkastettava sotu[PPKKVV-XXXT]: ");//" 13  10 52 -308 "
            string userInput = Console.ReadLine();

            userInput = RemoveSpaces(userInput);//"131052-308"
            if (IsValidLength(userInput,10))
            {
                int idNumber = InputParser(userInput);
                char getValidationMark = GetValidationMark(idNumber);
                PrintCreatedSSNumber(userInput + getValidationMark);
               // PrintCreatedSSNumber($"{userInput} { getValidationMark}");

            }


        }

        static void SSNChecker()
        {
            Console.WriteLine("\nAnna tarkastettava sotu[PPKKVV-XXXT]: ");
            string userInput = Console.ReadLine();

            userInput = RemoveSpaces(userInput);
            if (IsValidLength(userInput))
            {

                if (IsValidDate(userInput))
                {
                    int idNumber = InputParser(userInput);
                    char getLastChar = GetUserInputChkmark(userInput);
                    bool isOk = IsValidID(idNumber, getLastChar);
                    PrintResult(isOk);

                }

            }
            else
            {
                Console.WriteLine("Tarkasa hetun oikeellisuus-liikaa merkkejä");
            }
        }

        static char UserInterface()
        {
            Console.WriteLine("Henkilötunnuksen käsittely.");
            Console.WriteLine("[T] Tarkista henkilötunnuksen okeellisuus.");
            Console.WriteLine("[U]Luo uusi henkilötunnus.");
            Console.WriteLine("[X]Sulje  ohjelma.");
            Console.WriteLine("Valitse mitä tehdöön: ");

            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static bool IsValidDate(string userInput)
        {
            //"070496-161P"
            bool result = false;
            //
            string day = userInput.Substring(0, 2);
            string month = userInput.Substring(2, 2);
            string year = userInput.Substring(4, 2);
            string century = userInput.Substring(6, 1);

            if (century == "-")
            {
                year = "19" + year;
            }
            else if(century=="A")
            {
                year = "20" + year;
            }
            else
            {
                Console.WriteLine("Väärä vuosisata");
                return result;
            }

            //Taroastetaan päivämäärän oikeellisuus try-catch oikeellisuus
            try
            {
                DateTime birthday = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                result=true;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return result;
        }
        /// <summary>
        /// Check is userInuput correct length.
        /// Default Length is 11
        /// </summary>
        /// <param name="userInput"></param>
        /// <returns></returns>

        static bool IsValidLength(string userInput)
        {
            return userInput.Length == 11 ;


            
        }
        /// <summary>
        /// Check is userInput correct length.
        /// Varialble length is correct Length. Return true or false.
        /// </summary>
        /// <param name="userInput"></param>
        /// <param name="length"></param>
        /// <returns></returns>
        static bool IsValidLength(string userInput,int length)
        {
            return userInput.Length == length;
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
            string removed = stringParser;
            if (stringParser.Length > 10)
            {
                removed = stringParser.Remove(10, 1);
                // Testataan stringParser -muuttujan pituus
                //jos pituus on yli 10 niin poistetaan viimeinen merkki
            }           
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
        static void PrintCreatedSSNumber(string newSSNumber)
        {
            Console.WriteLine($"Luotu sotu on:{string newSSNumber}");
        }

        static char GetValidationMarkID(int idNumber)
        {
            string chkMark = "0123456789ABCDEFHJKLMNPRSTUVWXY";
            int modChecker = idNumber % 31;
            return chkMark[modChecker];
        }
        
    }
}
