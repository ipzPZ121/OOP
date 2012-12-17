using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    class Elips : Rect
    {
        private Dot a, b, c, d;
        private double perimmeter, square, stop;

        public Elips(Dot a, Dot b, Dot c, Dot d) : base (a, b , c ,d)
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


        public override double getSquare()
        {
            return Math.PI * a.getLengthTo(b)+c.getLengthTo(d);
        }

        public override double getPerimmeter()
        {
            return 4 * ((Math.PI * a.getLengthTo(b) * c.getLengthTo(d) + Math.Pow((a.getLengthTo(b) - c.getLengthTo(d)), 2))/(a.getLengthTo(b) + c.getLengthTo(d)));
        }

        public override string getInfo()
        {
            return "Elips: perimetter: " + getPerimmeter() + ", area: " + getSquare() + ", perimmeter/area: " + getStoP();
        }
    }
}
