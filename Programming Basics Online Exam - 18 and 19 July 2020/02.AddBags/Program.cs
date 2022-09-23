using System;

namespace _02.AddBags
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double baggagePrice = double.Parse(Console.ReadLine());
            double bagageKg = double.Parse(Console.ReadLine());
            int daysLeft = int.Parse(Console.ReadLine());
            int numberOfBags = int.Parse(Console.ReadLine());

            if (bagageKg < 10)
            {
                baggagePrice = baggagePrice / 10 * 2;
            }
            else if (bagageKg >= 10 && bagageKg <= 20)
            {
                baggagePrice = baggagePrice / 2;
            }

            if (daysLeft > 30)
            {
                baggagePrice = baggagePrice + (baggagePrice * 0.1); 
            }
            else if (daysLeft >= 7 && daysLeft <= 30)
            {
                baggagePrice = baggagePrice + (baggagePrice * 0.15);
            }
            else if (daysLeft < 7)
            {
                baggagePrice = baggagePrice + (baggagePrice * 0.4);
            }

            Console.WriteLine($"The total price of bags is: {baggagePrice * numberOfBags:f2} lv.");
        }
    }
}
