using System;

namespace _02.EqualSumsEvenOddPosition
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            
            for (int i = number1; i <= number2; i++)
            {
                string currentNumber = i.ToString();
                int odd = 0;
                int even = 0;
                for (int j = 0; j < currentNumber.Length; j++)
                {
                    int currentDigit = int.Parse(currentNumber[j].ToString());
                    if (j % 2 == 0)
                    {
                        even += currentDigit;
                    }
                    else
                    {
                        odd += currentDigit;
                    }
                }
                if (odd == even)
                {
                    Console.Write(i + " ");
                }

            }

        }
    }
}
