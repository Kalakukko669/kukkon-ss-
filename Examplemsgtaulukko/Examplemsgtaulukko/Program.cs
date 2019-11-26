using System;

namespace Examplemsgtaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkki jononkäsittely esimerkki");
            string message = "Hello Wordl!";
            
            Console.WriteLine($"{message} on {message.Length} merkkiä.");
            //split pystyt pätkii merkkijonoja omaksi taulukoksekseen tietoja omaan taulukkoon
            //substring== samakuin mid exelissä

            for (int i = 0; i <message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
        }
    }
}
