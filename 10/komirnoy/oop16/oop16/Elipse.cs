using System;

namespace oop16 {
    class Elipse
        : Rect, IShape {
        public override float Square {
            get { return (float)(Math.PI * (Width / 2f) * (Height / 2f)); }
        }

        public override float Perimetr {
            get { return (float)(2 * Math.PI * Math.Sqrt(Math.Pow((Width / 2f), 2) + Math.Pow((Height / 2f), 2)) / 2); }
        }

        public override string ClassName {
            get { return "Elipse"; }
        }

        public Elipse()
            : base() {
        }

        public Elipse(int X, int Y, int W, int H)
            : base(X, Y, W, H) {
        }

        public Elipse(Point point, int W, int H)
            : base(point.XCoord, point.YCoord, W, H) {
        }

        public Elipse(Elipse elipse)
            : base(elipse.XCoord, elipse.YCoord, elipse.Width, elipse.Height) {
        }
    }
}
