using System;

namespace _06.Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floorsNumber = int.Parse(Console.ReadLine());
            int roomsPerFloor = int.Parse(Console.ReadLine());
            
            for (int rows = floorsNumber; rows >= 1; rows--)
            {
                for (int cols = 0; cols < roomsPerFloor; cols++)
                {
                    if (rows == floorsNumber)
                    {
                        Console.Write($"L{rows}{cols} ");
                    }
                    else if (rows % 2 == 0)
                    {
                        Console.Write($"O{rows}{cols} ");
                    }
                    else
                    {
                        Console.Write($"A{rows}{cols} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
