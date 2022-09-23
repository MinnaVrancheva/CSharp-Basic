using System;

namespace _05.Coins
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double change = double.Parse(Console.ReadLine());
            double stotinki = Math.Floor(change * 100);
            int coins = 0;

            while (stotinki != 0)
            {
                if (stotinki - 200 >= 0)
                {
                    stotinki -= 200;
                    coins++;
                }
                else if (stotinki - 100 >= 0)
                {
                    stotinki -= 100;
                    coins++;
                }
                else if (stotinki - 50 >= 0)
                {
                    stotinki -= 50;
                    coins++;
                }
                else if (stotinki - 20 >= 0)
                {
                    stotinki -= 20;
                    coins++;
                }
                else if (stotinki - 10 >= 0)
                {
                    stotinki -= 10;
                    coins++;
                }
                else if (stotinki - 10 >= 0)
                {
                    stotinki -= 10;
                    coins++;
                }
                else if (stotinki - 5 >= 0)
                {
                    stotinki -= 5;
                    coins++;
                }
                else if (stotinki - 2 >= 0)
                {
                    stotinki -= 2;
                    coins++;
                }
                else if (stotinki - 1 >= 0)
                {
                    stotinki -= 1;
                    coins++;
                }
            }
            Console.WriteLine(coins);
        }
    }
}
