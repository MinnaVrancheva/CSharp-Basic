using System;

namespace _04.Club
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double revenue = double.Parse(Console.ReadLine());

            string coctail = Console.ReadLine();
            double income = 0;
            double finalPrice = 0;
            
            while (coctail != "Party!")
            {
                int price = coctail.Length;
                int number = int.Parse(Console.ReadLine());

                income = price * number;
                if (income % 2 == 1)
                {
                    income *= 0.75;
                }
                finalPrice += income;

                if (finalPrice >= revenue)
                {
                    Console.WriteLine($"Target acquired.");
                    Console.WriteLine($"Club income - {finalPrice:f2} leva.");
                }
                coctail = Console.ReadLine();
            }

            if (coctail == "Party!")
            {
                double needed = revenue - finalPrice;
                Console.WriteLine($"We need {needed:f2} leva more.");
                Console.WriteLine($"Club income - {finalPrice:f2} leva.");
            }
        }
    }
}
