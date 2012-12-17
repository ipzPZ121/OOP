using System;

namespace oop4 {
    class Rectangle {
        private int X;
        private int Y;
        private int W;
        private int H;

        public Rectangle() {
            X = Y = H = W = 0;
        }

        public Rectangle(int X, int Y, int W, int H) {
            this.X = X;
            this.Y = Y;
            this.W = W;
            this.H = H;
        }

        public Rectangle(Rectangle rect) {
            X = rect.GetX();
            Y = rect.GetY();
            W = rect.GetW();
            H = rect.GetH();
        }

        public Rectangle(int num) {
            if(num >= 1000 && num <= 9999) {
                X = int.Parse(num.ToString()[0].ToString());
                Y = int.Parse(num.ToString()[1].ToString());
                W = int.Parse(num.ToString()[2].ToString());
                H = int.Parse(num.ToString()[3].ToString());
            } else {
                X = Y = H = W = 0;
            }
        }

        public int GetX() {
            return X;
        }

        public int GetY()
        {
            return Y;
        }

        public int GetW()
        {
            return W;
        }

        public int GetH()
        {
            return H;
        }

        public void SetX(int vX) {
            X = vX;
        }

        public void SetY(int vY) {
            Y = vY;
        }

        public void SetW(int vW) {
            W = vW;
        }

        public void SetH(int vH) {
            H = vH;
        }

        public void Move(int dX, int dY) {
            X += dX;
            Y += dY;
        }

        public bool hitPoint(int pX, int pY) {
            return ((pX >= X && pX <= X + W) && (pY >= Y && pY <= Y + H));
        }

        public void Scale(int scale) {
            W *= scale;
            H *= scale;
        }

        public Rectangle Intersect(Rectangle rect) {
            Rectangle intersect = new Rectangle();
            intersect.SetX(X > rect.GetX() ? X : rect.GetX());
            intersect.SetY(Y > rect.GetY() ? Y : rect.GetY());
            intersect.SetW(((W - rect.W) > 0) ? (W - rect.W) : ((W - rect.W) * -1));
            intersect.SetH(((H - rect.H) > 0) ? (H - rect.H) : ((H - rect.H) * -1));

            return intersect;
        }

        public override string ToString()
        {
            return string.Format("Rectangle: [ X:{0}, Y:{1}, W:{2}, H:{3} ]", X, Y, W, H);
        }
    }
}
