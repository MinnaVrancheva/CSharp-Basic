using System;

namespace _06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int i = n1 / 1000; i <= n2 / 1000; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                for (int j = n1 / 100 % 10; j <= n2 / 100 % 10; j++)
                {
                    if (j % 2 == 0)
                    {
                        continue;
                    }
                    for (int k = n1 / 10 % 10; k <= n2 / 10 % 10; k++)
                    {
                        if (k % 2 == 0)
                        {
                            continue;
                        }
                        for (int l = n1 % 10; l <= n2 % 10; l++)
                        {
                            if (l % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{i}{j}{k}{l} ");
                        }
                    }
                }
            }
        }
    }
}
