using System;

namespace _05.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorName = Console.ReadLine();
            double academyPoints = double.Parse(Console.ReadLine());
            int judgesNumber = int.Parse(Console.ReadLine());

            double finalPoints = academyPoints;
            double judgeFinalPoints = 0;

            for (int i = 1; i <= judgesNumber; i++)
            {
                string judgeName = Console.ReadLine(); int length = judgeName.Length;
                double judgePoints = double.Parse(Console.ReadLine());

                judgeFinalPoints = length * judgePoints / 2;
                finalPoints += judgeFinalPoints;

                if (finalPoints > 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {finalPoints:f1}!");
                    break;
                }
                
            }
            if (finalPoints < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - finalPoints:f1} more!");
            }
        }
    }
}
