using System;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Structs;

namespace Presentation.Chapters
{
    internal class Chapter12 : IChapter
    {
        public void Execute()
        {
            DisplayType<Coords<int>>();
            DisplayType<Coords<double>>();
        }

        private static void DisplayType<T>() where T : unmanaged
        {
            Console.WriteLine($"{typeof(T)} is unmanaged");
        }
    }
}