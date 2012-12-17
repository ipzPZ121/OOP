using System;

    class Circle:Point
    {
        public new double Square()
        {
            return Math.PI * Width * Width / 4;
        }

        public new double Perimeter()
        {
            return Math.PI * Width;
        }
    }

