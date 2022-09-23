using System;

namespace _04.SumofTwoNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            
            int combination = 0;
            bool foundMagicNumber = false;

            for (int i = number1; i <= number2; i++)
            {
                for (int j = number1; j <= number2; j++)
                {
                    combination ++;

                    if (i + j == magicNumber)
                    {
                        foundMagicNumber = true;
                        Console.WriteLine($"Combination N:{combination} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }

                if (foundMagicNumber)
                {
                    break;
                }
            }
            if (!foundMagicNumber)
            {
                Console.WriteLine($"{combination} combinations - neither equals {magicNumber}");
            }
        }
    }
}
