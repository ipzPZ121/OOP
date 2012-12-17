using System;

namespace oop5 {
    abstract class Point {
        protected int X;
        protected int Y;

        public virtual float Square {
            get { return 0f; }
        }

        public virtual float Perimetr {
            get { return 0f; }
        }

        public virtual float RatioSqToPer {
            get { return 1f; }
        }

        public Point()
            : this(0, 0) {
        }

        public Point(int X, int Y) {
            SetPoint(X, Y);
        }

        public Point(Point point)
            : this(point.GetX(), point.GetY()) {
        }

        public void SetX(int X) {
            this.X = X;
        }

        public void SetY(int Y) {
            this.Y = Y;
        }

        public int GetX() {
            return X;
        }

        public int GetY() {
            return Y;
        }

        public virtual void SetPoint(int X, int Y) {
            SetX(X);
            SetY(Y);
        }

        public virtual void SetPoint(Point point) {
            SetPoint(point.GetX(), point.GetY());
        }

        public virtual void Move(int dX, int dY) {
            SetPoint(X + dX, Y += dY);
        }

        public virtual float GetSquare() {
            return Square;
        }

        public virtual float GetPerimeter() {
            return Perimetr;
        }

        public virtual float GetRatioSqToPer() {
            return RatioSqToPer;
        }

        public override string ToString() {
            return string.Format("Point: [ X: {0}, Y: {1} ]", GetX(), GetY());
        }
    }
}
