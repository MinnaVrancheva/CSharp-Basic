using System;

namespace _01.RoomPainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int paintBuckets = int.Parse(Console.ReadLine());
            int wallpaperNumber = int.Parse(Console.ReadLine());
            double glovesPrice = double.Parse(Console.ReadLine());
            double brushPrice = double.Parse(Console.ReadLine());

            double glovesNumber = (double)Math.Ceiling(wallpaperNumber * 0.35);
            double brushesNumber = (double)Math.Floor(paintBuckets * 0.48);

            double totalGlovesPrice = glovesNumber * glovesPrice;
            double totalBrushPrice = brushPrice * brushesNumber;
            double totalWallpaperPrice = wallpaperNumber * 5.20;
            double totalPaintBucketPrice = paintBuckets * 21.50;

            double totalPrice = (totalGlovesPrice + totalBrushPrice + totalWallpaperPrice + totalPaintBucketPrice) / 15;

            Console.WriteLine($"This delivery will cost {totalPrice:f2} lv.");
        }
    }
}
