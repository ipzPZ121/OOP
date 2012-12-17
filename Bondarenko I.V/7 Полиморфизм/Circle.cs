using System;

    class Circle:Point
    {
        public override double Square()
        {
            return Math.PI * Width * Width / 4;
        }

        public override double Perimeter()
        {
            return Math.PI * Width;
        }
    }

