using System;

namespace ReadWriteExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ReadWriteExample!");//Tulostaa näytölle viestin vkioviestinR ReadWrite Example
            Console.Write("Moi, Kirjoita nimesi:");//Tulostaa näytölle vakioviestin
            //Luetaan käyttäjän syöttämät merkit niin pitkään kunnes painetaan Enter
            //sijoitetaaan merkit merkkijonouttujaan userInput
            string userInput = Console.ReadLine();

            Console.WriteLine("--------------------------");//Tulostaa näytölle vakioviestin
            //Tulostaa näytölle vakioviestin ja muuujan userInput arvon
            Console.WriteLine("Moi " + userInput + "!");
            Console.WriteLine("Moi {0}", userInput);
            Console.WriteLine($"Moi{userInput}!");

            //Tulostuksen muotoilu ja muuttujien käyttö
            //tulostuksen yhteydessä $-merkin avulla = string.Format()

           
        }
    }
}
