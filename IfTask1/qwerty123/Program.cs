using System;

namespace qwerty123
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "qwerty1234";
            int attemptCounter = 0;

            Console.WriteLine("Syötä salasana.");
            string userInput = Console.ReadLine();

            while(userInput != password)
            {
                attemptCounter++;
                if (attemptCounter >= 3)
                {
                    Console.WriteLine("Tili on Lukittu!");
                    return;
                }
                Console.WriteLine("Väärin! Yritä uudelleen");
                userInput = Console.ReadLine();
            }

            Console.WriteLine("Salasana Oikein!");
        }
    }
}
