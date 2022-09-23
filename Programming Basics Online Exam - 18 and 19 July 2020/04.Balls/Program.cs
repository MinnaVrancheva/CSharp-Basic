using System;

namespace _04.Balls
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfBalls = int.Parse(Console.ReadLine());

            int totalNumber = 0;
            int red = 0;
            int orange = 0;
            int yellow = 0;
            int white = 0;
            int other = 0;
            int counter = 0;
            
            for (int i = 1; i <= numberOfBalls; i++)
            {
                string color = Console.ReadLine();
                switch (color)
                {
                    case "red":
                        red++;
                        totalNumber+= 5;
                        break;
                    case "orange":
                        orange++;
                        totalNumber+= 10;
                        break;
                    case "yellow":
                        yellow++;
                        totalNumber+= 15;
                        break;
                    case "white":
                        white++;
                        totalNumber+= 20;
                        break;
                    case "black":
                        counter++;
                        totalNumber /= 2;
                        break;
                    default:
                        other++;
                        break;
                }
            }
            Console.WriteLine($"Total points: {totalNumber}");
            Console.WriteLine($"Red balls: {red}");
            Console.WriteLine($"Orange balls: {orange}");
            Console.WriteLine($"Yellow balls: {yellow}");
            Console.WriteLine($"White balls: {white}");
            Console.WriteLine($"Other colors picked: {other}");
            Console.WriteLine($"Divides from black balls: {counter}");
        }
    }
}
