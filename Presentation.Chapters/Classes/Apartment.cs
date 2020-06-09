namespace Presentation.Chapters.Classes
{
    internal class Apartment
    {
        public string Name { get; set; }
        public static explicit operator House(Apartment a)
        {
            return new House() { Name = a.Name };
        }
    }
}