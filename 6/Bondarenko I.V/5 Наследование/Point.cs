﻿using System;

    class Point
    {
        int x;
        int y;
 
        private int width;
 
        public int Width
        {
            get { return width; }
            set { width = value; }
        }

        private int height;
 
        public int Height
        {
            get { return height; }
            set { height = value; }
        }
 
        public double Square()
        {
            return 0;
        }
 
        public double Perimeter()
        {
            return 0;
        }
 
        public double Relation()
        {
            if (Perimeter() == 0)
                return 0;
            return Square() / Perimeter();
        }
 
        public void Move(int dx, int dy)
        {
            x += dx;
            y += dy;
        }
 
        public override string ToString()
        {
            return String.Format("{0} x={1};y={2};width={3};height={4}",this.GetType().Name.ToString(),x,y,width,height);
        }
    }
    

