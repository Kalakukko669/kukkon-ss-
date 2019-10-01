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

            if (userInputNumber <= 0)
            {
               if(userInputNumber <= 0)
               {
                    Console.WriteLine($"Numero on {userInputNumber} is zero");
               }
               else
               {
                    if (userInputNumber % 2 == 0)
                        Console.WriteLine($"Numero on{userInputNumber} is negative");
                    {
                        if (userInputNumber < 0)
                            
                        {
                            Console.WriteLine($"Numero on{userInputNumber} is negative even");
                        }
                        else
                        {
                            Console.WriteLine($"Numero on{userInputNumber} is negative odd");
                        }
                    }
               }

            }
            else
            {
                if (userInputNumber % 2 == 0)
                    Console.WriteLine($"Numero on{userInputNumber} is positive even");
                {
                    if (userInputNumber < 0)
                    {
                        Console.WriteLine($"Numero on{userInputNumber} is positive odd");
                    }
                }
            }

        }
    }
}
