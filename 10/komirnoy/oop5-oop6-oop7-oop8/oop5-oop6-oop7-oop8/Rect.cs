using System;

namespace oop5 {
    class Rect 
        : Point {
        protected int W;
        protected int H;

        public override float Square {
            get { return (float)(W * H); }
        }

        public override float Perimetr {
            get { return (float)(W + H); }
        }

        public override float RatioSqToPer {
            get { return Square / Perimetr; }
        }

        public Rect()
            : this(0, 0, 0, 0) {
        }

        public Rect(int X, int Y, int W, int H)
            : base(X, Y) {
            SetW(W);
            SetH(H);
        }

        public Rect(Point point, int W, int H)
            : this(point.GetX(), point.GetY(), W, H) {
        }

        public Rect(Rect rect)
            : this(rect.GetX(), rect.GetY(), rect.GetW(), rect.GetH()) {
        }

        public int GetW() {
            return W;
        }

        public int GetH() {
            return H;
        }

        public virtual void SetW(int W) {
            this.W = W;
        }

        public virtual void SetH(int H) {
            this.H = H;
        }

        protected virtual string GetClassName() {
            return "Rect";
        }

        public override string ToString() {
            return string.Format("{0}: [ {1}, W: {2}, H: {3} ]", GetClassName(), base.ToString(), GetW(), GetH());
        }
    }
}
