using System;

namespace PasswordQueryExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "qwerty1234";
            Console.WriteLine("Salasanan kysely For-silmukalla");
            for(int i = 0; i < 3; i++)
            {
                Console.Write($"{i+1}Syötä salasana:");
                string userInput = Console.ReadLine();

                if(userInput== password)
                {
                    Console.WriteLine("Salasana Oikein!");
                    return;
                }
                else
                {
                    Console.WriteLine("Väärin meni! Yritä uudelleen");
                }
                
            }
            Console.WriteLine("Tili Lukittu!");
           
        }
    }
}
