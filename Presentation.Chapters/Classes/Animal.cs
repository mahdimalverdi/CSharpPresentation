using System;
using Presentation.Chapters.Abstraction;

namespace Presentation.Chapters.Classes
{
    internal class Animal<T> where T : ISound, new()
    {
        public ISound GetInstance()
        {
            //  return (ISound)Activator.CreateInstance(typeof(T));
            return new T();
        }
    }
}