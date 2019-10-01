using System;

namespace IfTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää käyttäjän syöttämästäl luvusta, onko se posotiivinen vai negatiivinen!");
            Console.Write("Syötä kokonaisluku: ");
            int userInputNumber = int.Parse(Console.ReadLine());

            if (userInputNumber == 0)
            {
                Console.WriteLine($"Luku {userInputNumber} on nolla!");
            }
            else
            {
                if (userInputNumber > 0)
                {
                    Console.WriteLine($"Luku {userInputNumber} on positiivinen.");
                }
                else
                {
                    Console.WriteLine($"Luku {userInputNumber} on negatiivinen.");
                }
            }
                                  
        }
    }
}
