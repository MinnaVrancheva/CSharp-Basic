using System;

namespace _03.Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double moneyNeeded = double.Parse(Console.ReadLine());
            double moneySaved = double.Parse(Console.ReadLine());

            int daysSpending = 0;
            int days = 0;

            while (moneySaved < moneyNeeded && daysSpending < 5)
            {
                string action = Console.ReadLine();
                double money = double.Parse(Console.ReadLine());

                days++;

                if (action == "spend")
                {
                    
                    daysSpending++;
                    moneySaved -= money; 

                    if (moneySaved < 0)
                    {
                        moneySaved = 0;
                    }

                    if (daysSpending == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine(days);
                        break;
                    }
                }
                else if (action == "save")
                {
                    moneySaved += money;
                }
            }
            if (moneySaved >= moneyNeeded)
            {
                Console.WriteLine($"You saved the money for {days} days.");
            }
        }
    }
}
