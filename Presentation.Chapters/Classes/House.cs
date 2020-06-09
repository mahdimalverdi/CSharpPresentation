namespace Presentation.Chapters.Classes
{
    internal class House
    {
        public string Name { get; set; }
        public static explicit operator Apartment(House h)
        {
            return new Apartment() { Name = h.Name };
        }
    }

}