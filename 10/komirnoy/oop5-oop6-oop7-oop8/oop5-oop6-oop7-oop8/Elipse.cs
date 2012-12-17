using System;

namespace oop5 {
    class Elipse
        : Rect {

        public override float Square {
            get { return (float)(Math.PI * (GetW() / 2f) * (GetH() / 2f)); }
        }

        public override float Perimetr {
            get { return (float)(2 * Math.PI * Math.Sqrt(Math.Pow((GetW() / 2f), 2) + Math.Pow((GetW() / 2f), 2)) / 2); }
        }

        public Elipse()
            : base() {
        }

        public Elipse(int X, int Y, int W, int H)
            : base(X, Y, W, H) {
        }

        public Elipse(Point point, int W, int H)
            : base(point.GetX(), point.GetY(), W, H) {
        }

        public Elipse(Elipse elipse)
            : base(elipse.GetX(), elipse.GetY(), elipse.GetW(), elipse.GetH()) {
        }

        protected override string GetClassName() {
            return "Elipse";
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
