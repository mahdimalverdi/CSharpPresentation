using System;
using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Classes;

namespace Presentation.Chapters
{
    internal class Chapter3 : IChapter
    {
        // event handler
        public static void bl_ProcessCompleted(object sender, ProcessEventArgs e)
        {
            Console.WriteLine("Process " + (e.IsSuccessful ? "Completed Successfully" : "failed"));
            Console.WriteLine("Completion Time: " + e.CompletionTime.ToLongDateString());
        }

        public void Execute()
        {
            ProcessBusinessLogic bl = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted; // register with an event
            bl.StartProcess();
        }
    }
}