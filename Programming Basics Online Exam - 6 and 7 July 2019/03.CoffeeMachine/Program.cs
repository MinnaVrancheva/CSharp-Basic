using System;

namespace _03.CoffeeMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string beverage = Console.ReadLine();
            string sugar = Console.ReadLine();
            int numberOfBeverages = int.Parse(Console.ReadLine());

            double price = 0;

            switch (beverage)
            {
                case "Espresso":
                    if (sugar == "Without")
                    {
                        price = 0.9 * 0.65;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1.00;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.2;
                    }
                    break;
                case "Cappuccino":
                    if (sugar == "Without")
                    {
                        price = 1.00 * 0.65;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 1.20;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 1.6;
                    }
                    break;
                case "Tea":
                    if (sugar == "Without")
                    {
                        price = 0.5 * 0.65;
                    }
                    else if (sugar == "Normal")
                    {
                        price = 0.6;
                    }
                    else if (sugar == "Extra")
                    {
                        price = 0.7;
                    }
                    break;
            }

            if (beverage == "Espresso" && numberOfBeverages >= 5)
            {
                price *= 0.75;
            }

            double finalPrice = numberOfBeverages * price;

            if (finalPrice >15)
            {
                finalPrice *= 0.80;
            }

            Console.WriteLine($"You bought {numberOfBeverages} cups of {beverage} for {finalPrice:f2} lv.");
        }
    }
}
