using System;


    class Rectangle:Point
    {
        public new double Square()
        {
            return Width * Height;
        }

        public new double Perimeter()
        {
            return (Width + Height) * 2;
        }
    }

