using System;

namespace _10.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfRows = int.Parse(Console.ReadLine());

            int evenNumber = 0;
            int oddNumber = 0;

            for (int i = 1; i <= numberOfRows; i++)
            {
                int number = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenNumber += number;
                }
                else
                {
                    oddNumber += number;
                }
            }
            if (evenNumber == oddNumber)
            {
                Console.WriteLine($"Yes\r\nSum = {evenNumber}");
            }
            else
            {
                Console.WriteLine($"No\r\nDiff = {Math.Abs(evenNumber - oddNumber)}");
            }
        }
    }
}
