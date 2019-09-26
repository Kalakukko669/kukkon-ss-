using System;

namespace kertoma3._1_example
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
            int fact = 1;

            // print message
            Console.WriteLine("Keroman laskenta");
            Console.Write("Minkä luvun kertoma lasketaan?");
            n = int.Parse(Console.ReadLine());

            if(n < 0)
            {
                Console.WriteLine("Virheellinen syöte!");
            }
            else
            {
                //silmukka, jossa lasketaan kertoman arvo
                while(n > 0)
                {
                    fact = fact * n; // lasketaan kertoma joka kierroksella
                    n = n - 1; // vähennetään arvoa yhdellä

                }
                // Print answer screen
                Console.WriteLine("Vastaus" + fact);
            }


        }
    }
}
