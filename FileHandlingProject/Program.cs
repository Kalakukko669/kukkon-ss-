using System;
using System.IO;

namespace FileHandlingProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tieodoston kirjoitus ja luku esimerkki.");
            string path = @"c:\temp\MyTest.txt";
            //string path = @"c:\\temp\\MyTest.txt";
            // Create a file to write to.
            DateTime currentTime = DateTime.Now;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{currentTime.Date}-------");
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
                sw.WriteLine("Tässä on Aatu");
            }




            // Open the file to read from.
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
