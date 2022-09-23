using System;

namespace _02.FamilyTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int numberNigts = int.Parse(Console.ReadLine());
            double pricePerNight = double.Parse(Console.ReadLine());
            int additionalExpences = int.Parse(Console.ReadLine());

            if (numberNigts > 7)
            {
                pricePerNight = pricePerNight * 0.95;
            }

            double overallAdditExpences = budget * additionalExpences / 100;
            double overallPrice = numberNigts * pricePerNight + overallAdditExpences;
            
            if (overallPrice <= budget)
            {
                double left = budget - overallPrice;
                Console.WriteLine($"Ivanovi will be left with {left:f2} leva after vacation.");
            }
            else
            {
                double needed = overallPrice - budget;
                Console.WriteLine($"{needed:f2} leva needed.");
            }
        }
    }
}
