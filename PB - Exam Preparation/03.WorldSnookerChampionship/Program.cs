using System;

namespace _03.WorldSnookerChampionship
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stage = Console.ReadLine();
            string ticketType = Console.ReadLine();
            int numberOfTickets = int.Parse(Console.ReadLine());
            string tropheyPicture = Console.ReadLine();

            double ticketPrice = 0;
            

            switch (stage)
            {
                case "Quarter final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 55.50;
                            break;
                        case "Premium":
                            ticketPrice = 105.20;
                            break;
                        case "VIP":
                            ticketPrice = 118.90;
                            break;
                    }
                    break;
                case "Semi final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 75.88;
                            break;
                        case "Premium":
                            ticketPrice = 125.22;
                            break;
                        case "VIP":
                            ticketPrice = 300.40;
                            break;
                    }
                    break;
                case "Final":
                    switch (ticketType)
                    {
                        case "Standard":
                            ticketPrice = 110.10;
                            break;
                        case "Premium":
                            ticketPrice = 160.66;
                            break;
                        case "VIP":
                            ticketPrice = 400;
                            break;
                    }
                    break;
            }

            double finalPrice = numberOfTickets * ticketPrice;
            bool freePhoto = false; 

            if (finalPrice > 4000)
            {
                finalPrice *= 0.75;
                freePhoto = true;
            }
            else if (finalPrice > 2500)
            {
                finalPrice *= 0.9;
            }

            if (tropheyPicture == "Y" && freePhoto == false)
            {
                finalPrice += 40 * numberOfTickets;
            }
            Console.WriteLine($"{finalPrice:f2}");

        }
    }
}
