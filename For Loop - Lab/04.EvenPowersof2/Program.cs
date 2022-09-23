using System;

namespace _04.EvenPowersof2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int number = 1;

            for (int i = 0; i <= n; i += 2)
            {
                Console.WriteLine(number);
                number *= 2 * 2;
            }
        }
    }
}
