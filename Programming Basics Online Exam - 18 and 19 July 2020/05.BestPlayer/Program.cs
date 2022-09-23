using System;

namespace _05.BestPlayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string playerName = Console.ReadLine();
            
            int newScore = 0;
            string bestPlayer = "";
            bool hasMadeHatTrick = false;

            while (playerName != "END")
            {
                int prevPlayerCounter = newScore;
                int numberOfGoals = int.Parse(Console.ReadLine());

                if (numberOfGoals >= 3)
                {
                    hasMadeHatTrick = true;
                }
                else
                {
                    hasMadeHatTrick = false;
                }
                newScore = numberOfGoals;

                if (prevPlayerCounter < numberOfGoals)
                {
                    newScore = numberOfGoals;
                    bestPlayer = playerName;
                }
                if (newScore >= 10)
                {
                    Console.WriteLine($"{bestPlayer} is the best player!");
                    Console.WriteLine($"He has scored {newScore} goals and made a hat-trick !!!");
                    return;
                }
                playerName = Console.ReadLine(); 
            }
            if (hasMadeHatTrick)
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {newScore} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"{bestPlayer} is the best player!");
                Console.WriteLine($"He has scored {newScore} goals.");
            }
        }
    }
}
