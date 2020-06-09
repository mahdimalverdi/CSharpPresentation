namespace Presentation.Chapters.Classes
{
    internal class Machine
    {
        public int _value;
        public static implicit operator Widget(Machine m)
        {
            Widget w = new Widget();
            w._value = m._value * 2;
            return w;
        }
    }
}