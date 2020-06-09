using System;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Classes;

namespace Presentation.Chapters
{
    internal class Chapter5 : IChapter
    {
        public void Execute()
        {
            Machine m = new Machine();
            m._value = 5;
            Console.WriteLine(m._value);

            // Implicit conversion from machine to widget.
            Widget w = m;
            Console.WriteLine(w._value);

            // Implicit conversion from widget to machine.
            Machine m2 = w;
            Console.WriteLine(m2._value);
        }
    }
}