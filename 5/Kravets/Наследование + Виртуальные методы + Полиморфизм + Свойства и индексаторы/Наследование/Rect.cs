using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Rect
    {
        private Dot a, b, c, d;
        private double perimmeter, square, stop;

        public Rect(Dot a, Dot b, Dot c, Dot d)
        {
            this.a = a;
            this.b = b;
            this.c = c;
            this.d = d;
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


        public virtual double getPerimmeter()
        {
            return 2 * (a.getLengthTo(b) + c.getLengthTo(d));
        }

        public virtual double getSquare()
        {
            return a.getLengthTo(b) * c.getLengthTo(d);
        }

        public virtual double getStoP()
        {
            return getSquare() / getPerimmeter();
        }

        public override string getInfo()
        {
            return "Rectangle: perimetter: " + getPerimmeter() + ", area: " + getSquare() + ", perimmeter/area: " + getStoP();
        }
    }
}
