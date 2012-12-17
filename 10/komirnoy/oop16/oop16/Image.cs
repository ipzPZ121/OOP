using System;
using System.Text;
using System.Collections.Generic;

namespace oop16 {
    class Image {
        protected List<IShape> image;

        public Image() {
            image = new List<IShape>();
        }

        public Image(Image image) {
            this.image = new List<IShape>(image.ToList());
        }

        public List<IShape> ToList() {
            return new List<IShape>(image);
        }

        public float GetTotalSquare() {
            float totalSquare = 0f;
            foreach (IShape p in image) {
                totalSquare += p.Square;
            }

            return totalSquare;
        }

        public float GetTotalPerimetr() {
            float totalPerimetr = 0f;
            foreach (IShape p in image) {
                totalPerimetr += p.Perimetr;
            }

            return totalPerimetr;
        }

        public void TotalMove(int dX, int dY) {
            foreach (IShape p in image) {
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
