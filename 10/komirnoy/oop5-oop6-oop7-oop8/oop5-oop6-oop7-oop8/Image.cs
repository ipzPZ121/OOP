using System;
using System.Text;
using System.Collections.Generic;

namespace oop5 {
    class Image {
        protected List<Point> image;

        public Image() {
            image = new List<Point>();
        }

        public Image(Image image) {
            this.image = new List<Point>(image.ToList());
        }

        public List<Point> ToList() {
            return new List<Point>(image);
        }

        public float GetTotalSquare() {
            float totalSquare = 0f;
            foreach (Point p in image) {
                totalSquare += p.GetSquare();
            }

            return totalSquare;
        }

        public float GetTotalPerimetr() {
            float totalPerimetr = 0f;
            foreach (Point p in image) {
                totalPerimetr += p.GetPerimeter();
            }

            return totalPerimetr;
        }

        public void Move(int dX, int dY) {
            foreach (Point p in image) {
                p.Move(dX, dY);
            }
        }

        public override string ToString() {
            StringBuilder builder = new StringBuilder();
            foreach (Point p in image) {
                builder.Append(p.ToString());
                builder.Append("\n");
            }

            return builder.ToString();
        }
    }
}
