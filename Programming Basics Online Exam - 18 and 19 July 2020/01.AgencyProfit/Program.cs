using System;

namespace _01.AgencyProfit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string companyName = Console.ReadLine();
            int adultTicketsNumber = int.Parse(Console.ReadLine());
            int kidTicketsNumber = int.Parse(Console.ReadLine());
            double netPrice = double.Parse(Console.ReadLine());
            double serviceFee = double.Parse(Console.ReadLine());

            double netPricePerKid = netPrice * 0.3;

            double adults = adultTicketsNumber * (serviceFee + netPrice);
            double kids = kidTicketsNumber * (serviceFee + netPricePerKid);

            double netProfit = adults + kids;
            double profit = netProfit / 10 * 2;
            Console.WriteLine($"The profit of your agency from {companyName} tickets is {profit:f2} lv.");
        }
    }
}
