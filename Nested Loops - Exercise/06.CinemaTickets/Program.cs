using System;

namespace _06.CinemaTickets
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string movieTitle = Console.ReadLine();

            int totalTicketsCount = 0;
            int studentTicket = 0;
            int standardTicket = 0;
            int kidsTicket = 0;

            while (movieTitle != "Finish")
            {
                int seats = int.Parse(Console.ReadLine());
                string ticketType = Console.ReadLine();
                int ticketsCountPerMovie = 0;
                

                while (ticketType != "End")
                {
                    switch (ticketType)
                    {
                        case "student":
                            studentTicket++;
                            ticketsCountPerMovie++;
                            totalTicketsCount++;
                            break;
                        case "standard":
                            standardTicket++;
                            ticketsCountPerMovie++;
                            totalTicketsCount++;
                            break;
                        case "kid":
                            kidsTicket++;
                            ticketsCountPerMovie++;
                            totalTicketsCount++;
                            break;
                    }

                    if (ticketsCountPerMovie >= seats)
                    {
                        break;
                    }
                    ticketType = Console.ReadLine();
                }

                double percentagePerMovie = 1.0 * ticketsCountPerMovie / seats * 100;
                Console.WriteLine($"{movieTitle} - {percentagePerMovie:f2}% full.");
                movieTitle = Console.ReadLine();
            }
            double studentsTicketsPerce = 1.0*studentTicket / totalTicketsCount * 100;
            double standardTicketsPerce = 1.0*standardTicket / totalTicketsCount * 100;
            double kidsTicketsPerce = 1.0*kidsTicket / totalTicketsCount * 100;

            Console.WriteLine($"Total tickets: {totalTicketsCount}");
            Console.WriteLine($"{studentsTicketsPerce:f2}% student tickets.");
            Console.WriteLine($"{standardTicketsPerce:f2}% standard tickets.");
            Console.WriteLine($"{kidsTicketsPerce:f2}% kids tickets.");
        }
    }
}
