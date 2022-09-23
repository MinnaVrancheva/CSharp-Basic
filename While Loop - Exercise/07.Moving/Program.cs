using System;

namespace _07.Moving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int heigth = int.Parse(Console.ReadLine());

            int volume = width * length * heigth;
            int parselsSum = 0;

            while (parselsSum <= volume)
            {
                string command = Console.ReadLine();
                if (command == "Done")
                {
                    Console.WriteLine($"{volume - parselsSum} Cubic meters left.");
                    break;
                }
                else
                {
                    int parsels = int.Parse(command);
                    parselsSum += parsels;
                }
            }
            if (parselsSum >= volume)
            {
                Console.WriteLine($"No more free space! You need {parselsSum - volume} Cubic meters more.");
            }
        }
    }
}
