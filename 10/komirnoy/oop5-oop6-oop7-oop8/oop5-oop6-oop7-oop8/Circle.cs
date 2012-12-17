using System;

namespace oop5 {
    class Circle
        : Elipse {
        protected int D;

        public Circle()
            : base() {
        }

        public Circle(int X, int Y, int D)
            : base(X, Y, D, D) {
        }

        public Circle(Point point, int D)
            : base(point, D, D) {
        }

        public Circle(Circle circle)
            : base(circle.GetX(), circle.GetY(), circle.GetW(), circle.GetH()) {
        }

        protected override string GetClassName() {
            return "Circle";
        }

        public override void SetW(int D) {
            base.SetW(D);
            base.SetH(D);
        }

        public override void SetH(int D) {
            base.SetW(D);
            base.SetH(D);
        }
    }
}
