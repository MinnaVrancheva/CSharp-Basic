using System;

namespace _04.TrainTheTrainers
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int judgesNumber = int.Parse(Console.ReadLine());

           string command = Console.ReadLine();
           double avgScoreSum = 0;
            int counter = 0;

           while (command != "Finish")
            {
                double avgScorePerPres = 0;

                for (int i = 1; i <= judgesNumber; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    avgScorePerPres += grade;
                    avgScoreSum += grade;
                    counter++;
                }
                double finalPerPres = avgScorePerPres / judgesNumber;
                Console.WriteLine($"{command} - {finalPerPres:f2}.");
                command = Console.ReadLine();
            }
           double finalAssesm = avgScoreSum / counter;
           Console.WriteLine($"Student's final assessment is {finalAssesm:f2}.");
        }
    }
}
