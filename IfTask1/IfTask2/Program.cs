using System;

namespace IfTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää onko luku parillinen vai pariton!");
            Console.Write("Syötä kokonaisluku: ");
            int UserInputNumber = int.Parse(Console.ReadLine());
            
            if (UserInputNumber % 2 == 0)
            {
                Console.WriteLine($"Numero {UserInputNumber} on parillinen");
            }
            else
            {
                Console.WriteLine($"Numero{UserInputNumber} on pariton");
            }
        }
    }
}
