using System;

namespace oop16 {
    class Rect 
        : Point, IShape {
        public override int Width {
            get { return W; }
            set { W = value < 0 ? 0 : value; }
        }

        public override int Height {
            get { return H; }
            set { H = value < 0 ? 0 : value; }
        }

        public override float Square {
            get { return (float)(Width * Height); }
        }

        public override float Perimetr {
            get { return (float)(Width + Height); }
        }

        public override float RatioSqToPer {
            get { return Square / Perimetr; }
        }

        public override string ClassName {
            get { return "Rect"; }
        }

        public Rect()
            : this(0, 0, 0, 0) {
        }

        public Rect(int X, int Y, int W, int H)
            : base(X, Y) {
            SetBounds(W, H);
        }

        public Rect(Point point, int W, int H)
            : this(point.XCoord, point.YCoord, W, H) {
        }

        public Rect(Rect rect)
            : this(rect.XCoord, rect.YCoord, rect.Width, rect.Height) {
        }

        private void SetBounds(int width, int height) {
            Width = width;
            Height = height;
        }

        public override string ToString() {
            return string.Format("{0}: [ {1}, W: {2}, H: {3} ]", ClassName, base.ToString(), Width, Height);
        }
    }
}
