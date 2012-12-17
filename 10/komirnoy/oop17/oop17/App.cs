using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop17 {
    class App {
        public static void Main(string[] args) {
            IStack st1 = new Stack();
            st1.Push(10);
            st1.Push(20);
            st1.Push(30);

            IStack st2 = new Stack();
            st2.Push("123");
            st2.Push("hello");
            st2.Push("abrakadabra");

            Console.WriteLine(st1);
            Console.WriteLine(st1.Pop());
            Console.WriteLine(st1);
            Console.WriteLine();
            Console.WriteLine(st2);

            Console.WriteLine();
            Console.WriteLine();

            IQueue q1 = new Queue();
            q1.Push(11);
            q1.Push(22);
            q1.Push(33);

            Console.WriteLine(q1);
            Console.WriteLine(q1.Pop());
            Console.WriteLine(q1);
            Console.WriteLine();
        }
    }
}
