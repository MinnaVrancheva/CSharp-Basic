using System;

namespace _03.SumPrimeNonPrime
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            
            int primeSum = 0;
            int nonPrimeSum = 0;

            while (input != "stop")
            {
                int number = int.Parse(input);
                int prime = 0;

                if (number < 0)
                {
                    Console.WriteLine($"Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }

                for (int i = 1; i <= number; i++)
                {
                    if (number % i == 0)
                    {
                        prime++;
                    }
                    
                }
                if (prime == 2)
                {
                    primeSum += number;
                }
                else
                {
                    nonPrimeSum += number;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {primeSum}");
            Console.WriteLine($"Sum of all non prime numbers is: {nonPrimeSum}");
        }
    }
}
