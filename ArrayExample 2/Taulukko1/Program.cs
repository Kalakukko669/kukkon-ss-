using System;

namespace Taulukko1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Taulukko harjoutus 1");
            // Esitellään ja lustetaan taulukko muuttujat
            decimal[] productPrice = new decimal[] { 7.96M, 72.0M, 99.90M };
            int[] productAmount = new int [] { 1, 3, 2 };//Tässä aset
            decimal[] productTotalPrice = new decimal[3];

            PriceCalculator(productPrice, productAmount);
            PrintTotalPrice(productTotalPrice);
          
        }

        static decimal[]PriceCalculator(decimal[]productPrice, int[] productAmount)
        {
           decimal[] productTotalPrice = new decimal[productAmount.Length];
            for (int i = 0; i<productAmount.Length; i++)
		    {
                productTotalPrice[i]=productPrice[i]*productAmount[i];
		    }
            return productTotalPrice;

        }
        static void PrintTotalPrice(decimal[] productTotalPrice)
        {
            for (int i = 0; i < productTotalPrice[i]; i++)
            {
                Console.WriteLine($"Tuote {i + 1}: {productTotalPrice[i]:c}");
            }
        }
           		
        
            
        
    }
}
