using System;

namespace _05.PuppyCare
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int petFoodInKg = int.Parse(Console.ReadLine());
            string status = Console.ReadLine();

            int foodInGrams = petFoodInKg * 1000;
            int foodConsumed = 0;

            while (status != "Adopted")
            {
                int foodPerGrams = int.Parse(status);
                foodConsumed += foodPerGrams;
                status = Console.ReadLine();
            }
            if (foodInGrams >= foodConsumed)
            {
                Console.WriteLine($"Food is enough! Leftovers: {foodInGrams - foodConsumed} grams.");
            }
            else
            {
                Console.WriteLine($"Food is not enough. You need {foodConsumed - foodInGrams} grams more.");
            }
        }
    }
}
