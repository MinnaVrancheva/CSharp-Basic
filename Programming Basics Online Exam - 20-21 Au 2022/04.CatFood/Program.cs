using System;

namespace _04.CatFood
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCats = int.Parse(Console.ReadLine());
            
            int group1 = 0;
            int group2 = 0;
            int group3 = 0;
            double food = 0;
            
            for (int i = 1; i <= numberOfCats; i++)
            {
                double foodInGramsPerCat = double.Parse(Console.ReadLine());
                if (foodInGramsPerCat >= 100 && foodInGramsPerCat < 200)
                {
                    group1++;
                    food+= foodInGramsPerCat;
                }
                else if (foodInGramsPerCat >= 200 && foodInGramsPerCat < 300)
                {
                    group2++;
                    food += foodInGramsPerCat;
                }
                else if (foodInGramsPerCat >= 300 && foodInGramsPerCat < 400)
                {
                    group3++;
                    food += foodInGramsPerCat;
                }
            }

            double foodKg = food / 1000;
            double foodPrice = foodKg * 12.45;
            Console.WriteLine($"Group 1: {group1} cats.");
            Console.WriteLine($"Group 2: {group2} cats.");
            Console.WriteLine($"Group 3: {group3} cats.");
            Console.WriteLine($"Price for food per day: {foodPrice:f2} lv.");
        }
    }
}
