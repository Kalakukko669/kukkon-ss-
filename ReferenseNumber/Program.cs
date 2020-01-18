using System;

namespace ReferenseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Program checks Referensenumber rightnes.");
            char userChoise;
            do
            {
                Console.Clear();
                userChoise = UserInterface();//Kutsutaan käyttöliittymä funktiota
                switch (userChoise)
                {
                    case 'C':
                        ReferenseNumberChecker();//Kutsutaa Referense Number checker
                        break;
                    case 'N':
                        ReferenseNumberCreator();//Kutsutaan Sotun luonti funktiota
                        break;
                    case 'M':
                        break;
                    case 'X':
                        break;

                    default:

                        Console.WriteLine("\nTarkasta mitä painoit! Enter jatkaa ohjelman suoritusta");
                        Console.ReadKey();
                        break;


                }
                Console.ReadLine();
            } while (userChoise != 'X');

        }//End MainProgram
        static char UserInterface()
        {
            return char.ToUpper(Console.ReadKey().KeyChar);
        }

        static void ReferenseNumberChecker()
        {
            char validMark;
            int numberLength = 0;
            Console.WriteLine
        }
        static void ReferenseNumberCreator()
        {

        }

    
    }
}
