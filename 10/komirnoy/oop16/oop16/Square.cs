using System;

namespace oop16 {
    class Square
        : Rect, IShape {
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
            get { return "Square"; }
        }

        public Square()
            : base() {
        }

        public Square(int X, int Y, int S)
            : base(X, Y, S, S) {
        }

        public Square(Point point, int S)
            : base(point, S, S) {
        }

        public Square(Square square)
            : base(square.XCoord, square.YCoord, square.Width, square.Height) {
        }
    }
}
