using System;

namespace _01.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favouriteBook = Console.ReadLine();
            string input = Console.ReadLine();
            int numberOfBooks = 0;

            while (input != "No More Books")
            {
                if (input == favouriteBook)
                {
                    Console.WriteLine($"You checked {numberOfBooks} books and found it.");
                    break;
                }
                numberOfBooks++;
                input = Console.ReadLine();
            }

            if (input == "No More Books")
            {
                Console.WriteLine($"The book you search is not here!");
                Console.WriteLine($"You checked {numberOfBooks} books.");
            }
        }
    }
}
