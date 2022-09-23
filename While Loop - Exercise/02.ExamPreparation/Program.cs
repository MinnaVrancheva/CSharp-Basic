using System;

namespace _02.ExamPreparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfAllowedFailures = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();

            double avg = 0;
            double problemsNumber = 0;
            string lastProblem = "";
            int failure = 0;
            int scoreCount = 0;

            while (command != "Enough")
            {
                
                int score = int.Parse(Console.ReadLine());

                if (score <= 4)
                {
                    failure++;

                    if (failure == numberOfAllowedFailures)
                    {
                        Console.WriteLine($"You need a break, {failure} poor grades.");
                        break;
                    }
                }
                lastProblem = command;
                problemsNumber++;
                
                scoreCount += score;
                avg = scoreCount / problemsNumber;
                command = Console.ReadLine();
            }
            if (command == "Enough")
            {
                Console.WriteLine($"Average score: {avg:f2}");
                Console.WriteLine($"Number of problems: {problemsNumber}");
                Console.WriteLine($"Last problem: {lastProblem}");
            }
        }
    }
}
