using System;


    class Ellipse:Point
    {
        public override double Square()
        {
            return Math.PI * (Width / 2) * (Height / 2);
        }

        public override double Perimeter()
        {
            return Math.PI * (Width / 2 + Height / 2);
        }
    }

