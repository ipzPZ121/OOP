using System;

namespace oop16 {
    class Circle
        : Elipse, IShape {
        public override int Width {
            get { return W; }
            set {
                base.Width = value;
                base.Height = value;
            }
        }

        public override int Height {
            get { return H; }
            set {
                base.Width = value;
                base.Height = value;
            }
        }

        public override string ClassName {
            get { return "Circle"; }
        }

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
            : base(circle.XCoord, circle.YCoord, circle.Width, circle.Height) {
        }
    }
}
