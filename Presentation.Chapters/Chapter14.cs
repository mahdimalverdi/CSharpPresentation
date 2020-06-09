using Presentation.Chapters.Abstraction;
using Presentation.Chapters.Classes;

namespace Presentation.Chapters
{
    internal class Chapter14 : IChapter
    {
        public void Execute()
        {
            var user = new User();

            user.Register();
            user.Login();
        }
    }
}