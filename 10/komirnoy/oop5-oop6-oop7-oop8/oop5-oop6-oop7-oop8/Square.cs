using System;

namespace oop5 {
    class Square
        : Rect {
        protected int S;

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
            : base(square.GetX(), square.GetY(), square.GetW(), square.GetH()) {
        }

        protected override string GetClassName() {
            return "Square";
        }

        public override void SetW(int S) {
            base.SetW(S);
            base.SetH(S);
        }

        public override void SetH(int S) {
            base.SetW(S);
            base.SetH(S);
        }
    }
}
