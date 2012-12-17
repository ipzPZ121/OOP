using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop16 {
    class App {
        public static void Main(string[] args) {
            IShape s = new Elipse();
            s.XCoord = 10;
            s.YCoord = 20;
            s.Width = 50;
            s.Height = 100;
            Console.WriteLine(s);
            Console.WriteLine();
        }
    }
}
