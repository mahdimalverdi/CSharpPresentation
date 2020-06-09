using System;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Classes;

namespace Presentation.Chapters
{
    internal class Chapter13 : IChapter
    {
        public void Execute()
        {
            var animal = new Animal<Dog>();
            var dog = animal.GetInstance();

            Console.WriteLine(dog.Sound);
        }
    }
}