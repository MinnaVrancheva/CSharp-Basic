using System;

namespace _04.Cinema
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int capacity = int.Parse(Console.ReadLine());
            int money = 0;
            int seats = 0;
            
            string command = Console.ReadLine();
            while (command != "Movie time!")
            {
                int numberOfPeople = int.Parse(command);
                seats += numberOfPeople;

                if (seats > capacity)
                {
                    Console.WriteLine($"The cinema is full.");
                    Console.WriteLine($"Cinema income - {money} lv.");
                    return;
                }
                if (numberOfPeople % 3 == 0)
                {
                    money += numberOfPeople * 5 - 5;
                }
                else
                {
                    money += numberOfPeople * 5;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"There are {capacity - seats} seats left in the cinema.");
            Console.WriteLine($"Cinema income - {money} lv.");
        }
    }
}
