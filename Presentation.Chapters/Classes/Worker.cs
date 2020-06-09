using System;

namespace Presentation.Chapters.Classes
{
    internal class Worker
    {
        // This method is called when the thread is started.
        public void DoWork()
        {
            bool work = false;
            while (!_shouldStop)
            {
                work = !work; // simulate some work
            }
            Console.WriteLine("Worker thread: terminating gracefully.");
        }
        public void RequestStop()
        {
            _shouldStop = true;
        }
        // Keyword volatile is used as a hint to the compiler that this data
        // member is accessed by multiple threads.
        // Simple types such as sbyte, byte, short, ushort, int, uint, char, float, and bool.
        private volatile bool _shouldStop;
    }
}