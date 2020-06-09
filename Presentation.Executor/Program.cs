using System;
using Presentation.Chapters.Factory;

namespace Presentation.Executor
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hello World!");

            var command = Console.ReadLine();

            var chapter = ChapterFactory.Create(command);

            chapter.Execute();

        }
    }
}
