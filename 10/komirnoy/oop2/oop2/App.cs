using System;
using System.IO;
using System.Reflection;

namespace oop2 {
    class App {
        static void Main(string[] args) {
            Table t = new Table();
            t.length = 150;
            t.width = 100;
            t.material = "пластик";

            t.Print();

            Table t2 = new Table();
            t2.length = 150;
            t2.width = 100;
            t2.material = "пластик";

            int compare = t.CompareTo(t2);
            Console.WriteLine(compare);

            Console.WriteLine();

            Complex c1 = new Complex();
            c1.real = 3;
            c1.imagin = 7;

            Complex c2 = new Complex();
            c2.real = 6;
            c2.imagin = 4;

            Console.WriteLine(c1.Sum(c2));

            Console.WriteLine();
        }
    }
}
