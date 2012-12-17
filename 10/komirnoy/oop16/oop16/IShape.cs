using System;

namespace oop16 {
    public interface IShape {
        int XCoord { get; set; }
        int YCoord { get; set; }
        int Width { get; set; }
        int Height { get; set; }
        float Square { get; }
        float Perimetr { get; }
        float RatioSqToPer { get; }
        string ClassName{ get; }
        void Move(int dX, int dY);
    }
}
