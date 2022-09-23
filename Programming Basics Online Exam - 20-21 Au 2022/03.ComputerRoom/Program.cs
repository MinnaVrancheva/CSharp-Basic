using System;

namespace _03.ComputerRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int hoursSpent = int.Parse(Console.ReadLine());
            int numberOfPeople = int.Parse(Console.ReadLine());
            string timeOfTheDay = Console.ReadLine();
            double price = 0;

            switch (month)
            {
                case "march":
                case "april":
                case "may":
                    switch (timeOfTheDay)
                    {
                        case "day":
                            price = 10.50;
                            break;
                        case "night":
                            price = 8.40;
                            break;
                    }
                    break;
                case "june":
                case "july":
                case "august":
                    switch (timeOfTheDay)
                    {
                        case "day":
                            price = 12.60;
                            break;
                        case "night":
                            price = 10.20;
                            break;
                    }
                    break;
            }
            if (hoursSpent >= 5)
            {
                price /= 2;
            }
            if (numberOfPeople >= 4)
            {
                price *= 0.9;
            }

            double finalPrice = price * numberOfPeople * hoursSpent;
            Console.WriteLine($"Price per person for one hour: {price:f2}");
            Console.WriteLine($"Total cost of the visit: {finalPrice:f2}");

        }
    }
}
