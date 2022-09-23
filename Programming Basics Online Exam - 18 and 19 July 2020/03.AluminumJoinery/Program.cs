using System;

namespace _03.AluminumJoinery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfProducts = int.Parse(Console.ReadLine());
            string type = Console.ReadLine();
            string delivery = Console.ReadLine();
            double price = 0;

            switch (type)
            {
                case "90X130":
                    price = 110;
                    if (numberOfProducts > 30 && numberOfProducts <= 60)
                    {
                        price *= 0.95;
                    }
                    else if (numberOfProducts > 60)
                    {
                        price *= 0.92;
                    }
                    break;
                case "100X150":
                    price = 140;
                    if (numberOfProducts > 40 && numberOfProducts <= 80)
                    {
                        price *= 0.94;
                    }
                    else if (numberOfProducts > 80)
                    {
                        price *= 0.90;
                    }
                    break;
                case "130X180":
                    price = 190;
                    if (numberOfProducts > 20 && numberOfProducts <= 50)
                    {
                        price *= 0.93;
                    }
                    else if (numberOfProducts > 50)
                    {
                        price *= 0.88;
                    }
                    break;
                case "200X300":
                    price = 250;
                    if (numberOfProducts > 25 && numberOfProducts <= 50)
                    {
                        price *= 0.91;
                    }
                    else if (numberOfProducts > 50)
                    {
                        price *= 0.86;
                    }
                    break;
            }

            double finalPrice = price * numberOfProducts;

            if (delivery == "With delivery")
            {
                finalPrice += 60;
            }
            
            if (numberOfProducts > 99)
            {
                finalPrice *= 0.96;
            }

            if (numberOfProducts < 10)
            {
                Console.WriteLine($"Invalid order");
            }
            else
            {
                Console.WriteLine($"{finalPrice:f2} BGN");
            }
        }
    }
}
