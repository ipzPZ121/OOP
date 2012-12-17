using System;

    class Square:Point
    {
        public new double Square()
        {
            return Width * Width;
        }

        public new double Perimeter()
        {
            return 4 * Width;
        }

    }

