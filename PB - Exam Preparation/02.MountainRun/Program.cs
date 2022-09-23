using System;

namespace _02.MountainRun
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double record = double.Parse(Console.ReadLine());
            double meters = double.Parse(Console.ReadLine());
            double secondsPerMeter = double.Parse(Console.ReadLine());

            double time = meters * secondsPerMeter;
            double delay = Math.Floor(meters / 50) * 30;
            double finalTime = time + delay;

            if (finalTime >= record)
            {
                Console.WriteLine($"No! He was {finalTime - record:f2} seconds slower.");
            }
            else
            {
                Console.WriteLine($"Yes! The new record is {finalTime:f2} seconds.");
            }
        }
    }
}
