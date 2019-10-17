using System;

namespace IfTask1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää kokonaisluvun arvon ja selvittää on luku parillinen vai pariton!");
            Console.Write("Syötä kokonaisluku:");
            int userInputNumber = int.Parse(Console.ReadLine());
            string positive;
            string even;
            if (userInputNumber % 2 == 0)
            {
                even = "parillinen";
            }
            else
            {
                even = "pariton";      
            }
            if(userInputNumber <= 0)
            {
                if(userInputNumber == 0)
                {
                    positive = "nolla";
                    Console.WriteLine($"Luku on {positive}");
                }
                else
                {
                    positive = "negatiivinen";
                    Console.WriteLine($"Luku  {userInputNumber} on {even} ja {positive}");
                }
            }
            else
            {
                positive = "positiivinen";
                Console.WriteLine($"Luku {userInputNumber} on {even} ja {positive}");
            }

        }
    }
}
    