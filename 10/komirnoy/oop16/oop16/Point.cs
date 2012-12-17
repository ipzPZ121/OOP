using System;

namespace oop16 {
    abstract class Point
        : IShape {
        protected int X;
        protected int Y;
        protected int W;
        protected int H;

        public virtual int XCoord {
            get { return X; }
            set { X = value; }
        }

        public virtual int YCoord {
            get { return Y; }
            set { Y = value; }
        }

        public virtual int Width {
            get { return 0; }
            set { W = 0; }
        }

        public virtual int Height {
            get { return 0; }
            set { H = 0; }
        }

        public virtual float Square {
            get { return 0f; }
        }

        public virtual float Perimetr {
            get { return 0f; }
        }

        public virtual float RatioSqToPer {
            get { return 1f; }
        }

        public virtual string ClassName {
            get { return "Point"; }
        }

        public Point()
            : this(0, 0) {
        }

        public Point(int X, int Y) {
            SetPoint(X, Y);
        }

        public Point(Point point)
            : this(point.XCoord, point.YCoord) {
        }

        private void SetPoint(int X, int Y) {
            XCoord = X;
            YCoord = Y;
        }

        private void SetPoint(Point point) {
            SetPoint(point.XCoord, point.YCoord);
        }

        public virtual void Move(int dX, int dY) {
            SetPoint(XCoord + dX, YCoord + dY);
        }

        public override string ToString() {
            return string.Format("Point: [ X: {0}, Y: {1} ]", XCoord, YCoord);
        }
    }
}
