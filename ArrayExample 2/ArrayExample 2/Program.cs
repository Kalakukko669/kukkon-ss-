using System;

namespace ArrayExample_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array esimerkki 2");
            Console.Write("Kuinka monta lukua arvotaan?");
            int size = int.Parse(Console.ReadLine());
            int[] arrayNumbers = new int[size];
            arrayNumbers = SetRandomNumbers(size, -10, 10);
            PrintArray(arrayNumbers);

            PrintArray(SetRandomNumbers(20, 5, 10));

        }

        /// <summary>
        /// Funktio arpoo halutun määrän lukuja taulukkoon, jonka
        /// lenght=taulukon koko
        /// minValue=alaraja
        /// maxValue=yläraja
        /// </summary>
        /// <param name="length"></param>
        /// <param name="minValue"></param>
        /// <param name="maxValue"></param>
        /// <returns></returns>
        static int[]SetRandomNumbers(int Length,int minValue, int maxValue)
        {
            int[] numbers = new int[Length];
            Random rnd = new Random();
            for (int i = 0; i < Length; i++)
            {
                numbers[i] = rnd.Next(minValue, maxValue + 1);
            }
            return numbers;
        }

        static void PrintArray(int[] arrX)
        {

            for (int i = 0; i < arrX.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {arrX[i]}");
            }
        }

    }
}
