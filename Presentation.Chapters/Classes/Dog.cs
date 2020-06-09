using Presentation.Chapters.Abstraction;

namespace Presentation.Chapters.Classes
{
    internal class Dog : ISound
    {
        public string Sound { get; set; } = "woof woof";
    }
}