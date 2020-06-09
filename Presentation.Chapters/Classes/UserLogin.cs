using System;
using Presentation.Chapters.Abstraction;

namespace Presentation.Chapters.Classes
{
    internal partial class User : ILogin
    {
        public void Login()
        {
            Console.WriteLine("Login");
        }
    }
}