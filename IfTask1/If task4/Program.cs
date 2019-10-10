using System;

namespace If_task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kolmen luvun lajittelu!");
            //Tietojen kysely
            Console.WriteLine("Syötä 1.luku");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä 2.luku");
            int d = int.Parse(Console.ReadLine());

            Console.WriteLine("Syötä 3.luku");
            int a = int.Parse(Console.ReadLine());
            //Logiikka jolla ongelma ratkaistaan
            if (x < d)
            {
                if (d < a)
                {
                    Console.WriteLine($" {x}, {d} , {a} ");
                }
                else
                {
                    if (x > a)
                    {
                        Console.WriteLine($" {a} , {x} , {d}");
                    }
                    else
                    {
                        Console.WriteLine($" {x} , {a} , {d} ");
                    }
                }

            }
            else if (x < a)
            {
                Console.WriteLine($" {d} , {x} , {a} ");
            }
            else if (d > a)
            {
                Console.WriteLine($" {d} ,{a} , {x} ");
            }
            else
            {
                Console.WriteLine($" {a} , {d} ,{x}");
            }











        }
    }
}
