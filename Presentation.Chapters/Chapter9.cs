using System;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Structs;

namespace Presentation.Chapters
{
    internal class Chapter9 : IChapter
    {
        private static void StructEventHandler(int point)
        {
            Console.WriteLine("Point changed to {0}", point);
        }

        public void Execute()
        {
            Point p = new Point();

            p.PointChanged += StructEventHandler;
            p.X = 10;
        }
    }
}