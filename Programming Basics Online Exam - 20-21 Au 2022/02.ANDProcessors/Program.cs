using System;

namespace _02.ANDProcessors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int processorsNumberToReach = int.Parse(Console.ReadLine());
            int employeesNumber = int.Parse(Console.ReadLine());
            int workingDaysNumber = int.Parse(Console.ReadLine());

            double workingHours = workingDaysNumber * 8 * employeesNumber;
            double craftedProcessors = (double)Math.Floor(workingHours / 3);

            if (craftedProcessors >= processorsNumberToReach)
            {
                double profit = (craftedProcessors - processorsNumberToReach) * 110.10;
                Console.WriteLine($"Profit: -> {profit:f2} BGN");
            }
            else
            {
                double loss = (processorsNumberToReach - craftedProcessors) * 110.10;
                Console.WriteLine($"Losses: -> {loss:f2} BGN");
            }
        }
    }
}
