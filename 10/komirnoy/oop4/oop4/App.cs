using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop4 {
    class App {
        public static void Main(string[] args) {
            MyVectorArr vecArr = new MyVectorArr();
            vecArr.Append(1);
            vecArr.Append(23);
            vecArr.Append(234);
            vecArr.Append(4);
            vecArr.Append(9);

            vecArr.Insert(11, 1);
            vecArr.Remove(2);

            Console.WriteLine(vecArr);
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
