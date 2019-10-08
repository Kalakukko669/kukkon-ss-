using System;

namespace IfTask1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma lukee syötteesi ja selvittää arvon!");
            Console.Write("Syötä kokonaisluku:");
            int userInputNumber = int.Parse(Console.ReadLine());
            string positive;
            string even;

            if (userInputNumber % 2 == 0)
            {
                even = "parillinen";
            }
            else

                even = " pariton";

            if (userInputNumber == 0)
            {
                positive = " nolla";
                Console.WriteLine($"Luku {userInputNumber} on {positive} ja {even} !");
            }
            else

                if (userInputNumber > 0)
                {
                positive = "positiivinen";

                }
                else
                {
                positive = "negatiivinen";

                }
                Console.WriteLine($"Luku {userInputNumber} on {positive} ja {positive} !");
        }
    }
}
    