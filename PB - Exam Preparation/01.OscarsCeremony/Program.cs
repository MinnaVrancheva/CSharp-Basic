using System;

namespace _01.OscarsCeremony
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rent = int.Parse(Console.ReadLine());

            double oscars = rent * 0.7;
            double catering = oscars * 0.85;
            double music = catering / 2;
           

            Console.WriteLine($"{rent + oscars + catering + music:f2}");
        }
    }
}
