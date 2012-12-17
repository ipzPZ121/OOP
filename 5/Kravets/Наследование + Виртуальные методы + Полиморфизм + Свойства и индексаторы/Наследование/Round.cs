using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Round : Rect
    {
        private Dot a, b, c, d;
        private double radius, perimmeter, square, stop;

        public Round(Dot a, Dot b, Dot c, Dot d)
            : base(a, b, c, d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
            radius = a.getLengthTo(b) / 2;
            if(a.getLengthTo(b)!=c.getLengthTo(d))
                throw new System.ArgumentOutOfRangeException("Sides can't be different");
        }

        public double Perimmeter
        {
            get { perimmeter = getPerimmeter(); return perimmeter; }
            set { perimmeter = value; }

        }

        public double Square
        {
            get { square = getSquare(); return square; }
            set { square = value; }
        }

        public double StoP
        {
            get { stop = getStoP(); return StoP; }
            set { stop = value; }
        }

        public override double getPerimmeter()
        {
            return 2 * Math.PI * radius;
        }

        public override double getSquare()
        {
            return Math.Pow((Math.PI * radius), 2);
        }

        public override string getInfo()
        {
            return "Round: perimetter: " + getPerimmeter() + ", area: " + getSquare() + ", perimmeter/area: " + getStoP();
        }
    }
}
