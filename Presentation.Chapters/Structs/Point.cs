using System;

namespace Presentation.Chapters.Structs
{
    internal struct Point
    {
        private int x, y;

        public int X
        {
            get
            {
                return x;
            }

            set
            {
                x = value;
                PointChanged(x);
            }
        }

        public int Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
                PointChanged(y);
            }
        }

        public event Action<int> PointChanged;
    }
}