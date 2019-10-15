using System;

namespace iftask32
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma laskee N lukujen summan");
            Console.Write("Syötä luku:");
            int userInput = int.Parse(Console.ReadLine());

            Console.WriteLine("For---------------------");
            for (int i = 0; i < userInput; i++)
            {
                Console.WriteLine(i+1);
            }

            Console.WriteLine("While---------------------");
            int j = 0;//Laskurin määritys
            while (j < userInput)// Silmukan ehto. Silmukkaan mennään niin pitkään kunnes se on epätosi.
            {
                j++; //Laskurin kasvatus yhdellä
                Console.WriteLine(j);//Tulostus
            }

           
            Console.WriteLine("DoWhile-----------------");

            int n = 0; //
            do
            {
                n++;
                Console.WriteLine(n);
            } while (n < userInput);

            Console.WriteLine("Ohjelman suoritus on päättynyt!");
                
            

        }
    }
}
