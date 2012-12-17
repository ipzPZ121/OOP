using System;


    class Rectangle
    {
        int x, y, w, h;

        public Rectangle()
        {
            x = 0;
            y = 0;
            w = 1;
            h = 1;
        }

        public Rectangle(int nx, int ny, int nw, int nh)
        {
            x = nx;
            y = ny;
            w = nw;
            h = nh;
        }

        public Rectangle(Rectangle rec)
        {
            x = rec.GetX();
            y = rec.GetY();
            w = rec.GetWeight();
            h = rec.GetHeight();
        }

        public Rectangle(string str)
        {
            x = (int)str[0];
            y = (int)str[1];
            w = (int)str[2];
            h = (int)str[3];
        }

        public int GetX()
        {
            return x;
        }

        public int GetY()
        {
            return y;
        }

        public int GetWeight()
        {
            return w;
        }

        public int GetHeight()
        {
            return h;
        }

        public void MoveIn(int newX, int newY)
        {
            x = newX;
            y = newY;
        }

        public void MoveOn(int dX, int dY)
        {
            x += dX;
            y += dY;
        }

        public bool IsPointOnRec(int pointX, int pointY)
        {
            if (pointX >= x && pointX <= (x + w) && pointY >= y && pointY <= (y + h))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public void ScaleRec(int scale)
        {
            w *= scale;
            h *= scale;
        }

        public void Intersection(Rectangle rec)
        {
            w = x + w - rec.GetX();
            h = y + h - rec.GetY();
            x = rec.GetX();
            y = rec.GetY();
            
        }

        
    }

