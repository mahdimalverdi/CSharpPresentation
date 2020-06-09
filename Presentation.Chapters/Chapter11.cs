using System;
using System.Threading;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Classes;

namespace Presentation.Chapters
{
    internal class Chapter11 : IChapter
    {
        public void Execute()
        { // Create the worker thread object. This does not start the thread.
            Worker workerObject = new Worker();
            Thread workerThread = new Thread(workerObject.DoWork);

            // Start the worker thread.
            workerThread.Start();
            Console.WriteLine("Main thread: starting worker thread...");

            // Loop until the worker thread activates.
            while (!workerThread.IsAlive)
                ;

            // Put the main thread to sleep for 500 milliseconds to
            // allow the worker thread to do some work.
            Thread.Sleep(500);

            // Request that the worker thread stop itself.
            workerObject.RequestStop();

            // Use the Thread.Join method to block the current thread
            // until the object's thread terminates.
            workerThread.Join();
            Console.WriteLine("Main thread: worker thread has terminated.");
        }
    }
}