using System;
using System.Collections.Generic;
using System.Text;

namespace oop19 {
    class App {
        public static void Main(string[] args) {
            Set<string> s = new Set<string>();
            s.AddWord("123");
            s.AddWord("234");
            s.AddWord("345");

            Set<string> s2 = new Set<string>();
            s2.AddWord("321");
            s2.AddWord("234");
            s2.AddWord("345");

            Console.WriteLine(s);
            Console.WriteLine();

            Console.WriteLine(s2);
            Console.WriteLine();

            Set<string> s3 = s.Sum(s2);
            Console.WriteLine(s3);

            Set<string> s4 = s.Sub(s2);
            Console.WriteLine(s4);

            Set<string> s5 = s.Intersect(s2);
            Console.WriteLine(s5);
            Console.WriteLine();
        }
    }
}
