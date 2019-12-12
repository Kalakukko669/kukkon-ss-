using System;

namespace Examplemsgtaulukko
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Merkki jononkäsittely esimerkki");
            string message = "  Hello Wordl!  ";
            
            Console.WriteLine($"{message} on {message.Length} merkkiä.");

            PrintMessage(message);
            //split pystyt pätkii merkkijonoja omaksi taulukoksekseen tietoja omaan taulukkoon
            //substring== samakuin mid exelissä
            //index of voidaan etsiä haluttu merkki ja palautaa sen paikan sijainti
            string tempMessage= message.Trim();
            for (int i = 0; i <message.Length; i++)
            {
                Console.WriteLine(message[i]);
            }
            static void PrintMessage(string s)
            {
                for (int i = 0; i < s.Length; i++)
                {
                    Console.WriteLine(s[i]);
                }
            }
        }
    }
}
