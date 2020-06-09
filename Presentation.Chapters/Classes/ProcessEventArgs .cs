using System;

namespace Presentation.Chapters.Classes
{
    internal class ProcessEventArgs : EventArgs
    {
        public bool IsSuccessful { get; set; }
        public DateTime CompletionTime { get; set; }
    }
}