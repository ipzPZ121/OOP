using System;


    class Rectangle:Point
    {
        public override double Square()
        {
            return Width * Height;
        }

        public override double Perimeter()
        {
            return (Width + Height) * 2;
        }
    }

