using System;

namespace _06.Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cakeSize1 = int.Parse(Console.ReadLine());
            int cakeSize2 = int.Parse(Console.ReadLine());

            int cakePieces = cakeSize1 * cakeSize2;
            int pieces = 0;

            while (pieces < cakePieces)
            {
                string command = Console.ReadLine();
                if (command == "STOP")
                {
                    Console.WriteLine($"{cakePieces - pieces} pieces are left.");
                    break;
                }
                else
                {
                    pieces += int.Parse(command);
                }
            }

            if (pieces >= cakePieces)
            {
                Console.WriteLine($"No more cake left! You need {pieces - cakePieces} pieces more.");
            }
        }
    }
}
