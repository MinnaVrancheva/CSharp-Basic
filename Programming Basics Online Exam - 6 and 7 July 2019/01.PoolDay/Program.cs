using System;

namespace _01.PoolDay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            double entranceFee = double.Parse(Console.ReadLine());
            double stoolFee = double.Parse(Console.ReadLine());
            double umbrellaFee = double.Parse(Console.ReadLine());

            double totalEntranceFee = entranceFee * numberOfPeople;
            double totalUmbrellaFee = Math.Ceiling(numberOfPeople / 2.0);
            double totalStoolFee = Math.Ceiling(numberOfPeople * 0.75);

            double total = totalEntranceFee + totalStoolFee*stoolFee + totalUmbrellaFee*umbrellaFee;

            Console.WriteLine($"{total:f2} lv.");
        }
    }
}
