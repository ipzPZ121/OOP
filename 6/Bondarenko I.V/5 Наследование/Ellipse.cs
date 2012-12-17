using System;


    class Ellipse:Point
    {
        public new double Square()
        {
            return Math.PI * (Width / 2) * (Height / 2);
        }

        public new double Perimeter()
        {
            return Math.PI * (Width / 2 + Height / 2);
        }
    }

