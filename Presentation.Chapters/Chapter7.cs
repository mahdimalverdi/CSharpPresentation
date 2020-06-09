using System;
using Presentation.Chapters.Abstraction;

namespace Presentation.Chapters
{
    internal class Chapter7 : IChapter
    {
        public void Execute()
        {
            int x = 200, y = 4;
            int count = 0;
            string[,] array = new string[x, y];

            // Initialize the array.
            for (int i = 0; i < x; i++)
                for (int j = 0; j < y; j++)
                    array[i, j] = (++count).ToString();

            // Read input.
            Console.Write("Enter the number to search for: ");

            // Input a string.
            string myNumber = Console.ReadLine();

            // Search.
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (array[i, j].Equals(myNumber))
                    {
                        goto Found;
                    }
                }
            }

            Console.WriteLine($"The number {myNumber} was not found.");
            goto Finish;

        Found:
            Console.WriteLine($"The number {myNumber} is found.");

        Finish:
            Console.WriteLine("End of search.");
        }
    }
}