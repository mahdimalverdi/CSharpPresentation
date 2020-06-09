using System;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Classes;

namespace Presentation.Chapters
{
    internal class Chapter4 : IChapter
    {
        public void Execute()
        {
            House h = new House();
            h.Name = "Broadway";

            // Cast a House to an Apartment.
            Apartment a = (Apartment)h;

            // Apartment was converted from House.
            Console.WriteLine(a.Name);
        }
    }
}