using System;
using Presentation.Chapters.Abstraction;

namespace Presentation.Chapters.Classes
{
    internal partial class User : IRegister
    {
        public void Register()
        {
            Console.WriteLine("Register");
        }
    }
}