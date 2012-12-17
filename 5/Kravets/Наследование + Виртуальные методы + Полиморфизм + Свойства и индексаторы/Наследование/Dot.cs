using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Наследование
{
    abstract class Dot
    {
        private int x1, y1;

        public Dot(int x1, int y1)
        {
            this.x1 = x1;
            this.y1 = y1;
        }

        public void moveHorizontal(int abs) {
            x1+=abs;
        }

        public void moveVertical(int abs)
        {
            y1 += abs;
        }

        public double getLengthTo(Dot b)
        {
            return Math.Sqrt(Math.Pow((b.x1 - x1), 2) + Math.Pow((b.y1 - y1), 2)); 
        }

        public virtual string getInfo()
        {
            return "Dot: + X = "+ x1 + " Y = "+y1;
        }
    }
}
