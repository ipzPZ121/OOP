using System;

    class Square:Point
    {
        public override double Square()
        {
            return Width * Width;
        }

        public override double Perimeter()
        {
            return 4 * Width;
        }

    }

