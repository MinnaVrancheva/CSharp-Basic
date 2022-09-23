using System;

namespace _05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int textLength = text.Length;

            for (int value = 0; value <= textLength - 1; value++)
            {
                Console.WriteLine(text[value]);
            }

        }
    }
}
