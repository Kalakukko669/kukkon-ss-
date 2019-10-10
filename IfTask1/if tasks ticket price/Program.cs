using System;

namespace if_tasks_ticket_price
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ohjelma selvittää lipun hinan asiakkaan!");
            Console.Write("Syötä ikäsi:");
            double age = double.Parse(Console.ReadLine());
            double discount = 0;
            double price = 16;
            string isConsricpt;
            string isMtkMember;
            string isStudent;
            if (age < 7)
            {
                discount = 1.0;
            }
            else
            {
                if (age > 7 & age < 15)
                {
                    discount = 0.5;
                }
                else
                {
                    if (age == 65 & age > 65)
                    {
                        discount = 0.5;
                    }
                    else
                    {
                        Console.WriteLine("Onko Mtk jäsen?y/n");
                        isMtkMember = Console.ReadLine();
                        if (isMtkMember == "y")
                        {
                            discount = 0.15;
                        }

                        Console.WriteLine("Onko Opiskelija ?y/n");
                        isStudent = Console.ReadLine();
                        if (isStudent == "y")
                        {
                            discount = discount + 0.45;
                        }
                        else
                        {
                            Console.WriteLine("Onko Varusmies ?y/n");
                            isConsricpt = Console.ReadLine();
                            if (isConsricpt == "y")
                            {
                                discount = 0.5;
                            }
                        }
                    }
                }
            }
            Console.WriteLine($"Lipun hinta on {price - (price * discount)}");
        }
    }
}
