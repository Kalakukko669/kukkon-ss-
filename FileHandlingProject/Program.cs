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

            WriteToFile(path);
            Readfile(path);
  
        }
        static void WriteToFile(string path)
        {
            DateTime currentTime = DateTime.Now;
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine($"{currentTime.Date}-------");
                sw.WriteLine("Hello");
                sw.WriteLine("And");
                sw.WriteLine("Welcome");
                sw.WriteLine("Tässä on Aatu");
            }
        }
        static void Readfile(string path)
        {
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
