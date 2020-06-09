namespace Presentation.Chapters.Classes
{
    internal class Widget
    {
        public int _value;
        public static implicit operator Machine(Widget w)
        {
            Machine m = new Machine();
            m._value = w._value / 2;
            return m;
        }
    }
}