﻿using System;

namespace _06.BarcodeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            for (int b1 = n1 / 1000; b1 <= n2 / 1000; b1++)
            {
                if (b1 % 2 == 0)
                {
                    continue;
                }
                for (int b2 = n1 / 100 % 10; b2 <= n2 / 100 % 10; b2++)
                {
                    if (b2 % 2 == 0)
                    {
                        continue;
                    }
                    for (int b3 = n1 / 10 % 10; b3 <= n2 / 10 % 10; b3++)
                    {
                        if (b3 % 2 == 0)
                        {
                            continue;
                        }
                        for (int b4 = n1 % 10; b4 <= n2 % 10; b4++)
                        { 
                            if (b4 % 2 == 0)
                            {
                                continue;
                            }
                            Console.Write($"{b1}{b2}{b3}{b4} ");
                        }
                    }
                }
            }
        }
    }
}
