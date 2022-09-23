using System;

namespace _06.GoldMine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPlaces = int.Parse(Console.ReadLine());


            for (int i = 1; i <= numberOfPlaces; i++)
            {
                double goalToBeReached = double.Parse(Console.ReadLine());
                int daysNumber = int.Parse(Console.ReadLine());
                double goldDig = 0;

                for (int j = 1; j <= daysNumber; j++)
                {
                    double goldPerDay = double.Parse(Console.ReadLine());
                    goldDig += goldPerDay;

                }
                double goldDigForAllDays = goldDig / daysNumber;

                if (goldDigForAllDays >= goalToBeReached)
                {
                    Console.WriteLine($"Good job! Average gold per day: {goldDigForAllDays:f2}.");
                }
                else
                {
                    double less = goalToBeReached - goldDigForAllDays;
                    Console.WriteLine($"You need {less:f2} gold.");
                }
            }
        }
    }
}
