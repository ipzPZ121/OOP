using System;


    class Rectangle
    {
        public int x, y, w, h;

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
            x = rec.x;
            y = rec.y;
            w = rec.w;
            h = rec.h;
        }

        public Rectangle(string str)
        {
            x = Convert.ToInt32(str[0]);
            y = Convert.ToInt32(str[1]);
            w = Convert.ToInt32(str[2]);
            h = Convert.ToInt32(str[3]);
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
            w = x + w - rec.x;
            h = y + h - rec.y;
            x = rec.x;
            y = rec.y;
            
        }
    }

