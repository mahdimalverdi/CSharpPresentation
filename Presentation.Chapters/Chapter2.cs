using Presentation.Chapters.Abstraction;
using System;

namespace Presentation.Chapters
{
    internal class Chapter2 : IChapter
    {
        public delegate void Del(string message);
        public void Execute()
        {
            // Instantiate the delegate.
            Del handler1 = DelegateMethod1;

            // Call the delegate.
            handler1("Chapter2 is executing!");

            Del handler2 = DelegateMethod2;

            MethodWithCallback(1, 2, handler2);
        }

        // Create a method for a delegate.
        private static void DelegateMethod1(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        // Create a method for a delegate.
        private static void DelegateMethod2(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback($"The number is: {param1 + param2}");
        }
    }
}