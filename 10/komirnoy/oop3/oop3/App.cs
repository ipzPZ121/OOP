﻿using System;

namespace oop3 {
    class App {
        public static void Main(string[] args) {
            MyVector vec = new MyVector();
            vec.Append(1);
            vec.Append(23);
            vec.Append(234);
            vec.Append(4);
            vec.Append(9);

            vec.Insert(11, 1);
            vec.Remove(2);

            Console.WriteLine(vec);
            Console.WriteLine();
            
            Rectangle r1 = new Rectangle();
            Console.WriteLine(r1);
            Rectangle r2 = new Rectangle(5689);
            Console.WriteLine(r2);
            Rectangle r3 = new Rectangle(r2);
            Console.WriteLine(r3);
            Rectangle r4 = new Rectangle(23, 56, 85, 100);
            Console.WriteLine(r4);

            Console.WriteLine();
        }
    }
}
