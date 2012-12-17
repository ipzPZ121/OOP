using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Table
    {
        private double width;
        private double height;
        private string material;

        public Table(double w, double h, string m)
        {
            width = w;
            height = h;
            material = m;
        }

        public Table(double w, double h)
        {
            width = w;
            height = h;
            material = "plastik";
        }
        public Table()
        {
            width = 1.5;
            height = 0.8;
            material = "derevo";
        }

        public double Width
        {
            get { return width; }
        }

        public double Height
        {
            get { return height; }
        }

        public string Material
        {
            get { return material; }
        }

        public override string ToString()
        {
            return string.Format("{{width={0},heigth={1}},material={2}}", width, height,material);
        }

        
            public bool Equals(Table obj)
        {
                if (this.Width==obj.Width && this.Height==obj.Height && this.Material==obj.Material )
                {
                    return true;
                }
                else
                {
                    return false;
                }
            
            
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
