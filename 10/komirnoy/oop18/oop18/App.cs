using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop18 {
    class App {
        public static void Main(string[] args) {
            MyDictionary dict = new MyDictionary();
            dict.Add(1, "Hello");
            dict.Add(2, "World");
            dict.Add(3, "Error");
            dict[4] = "Next";

            Console.WriteLine(dict);
            Console.WriteLine();

            PhoneBook pB = new PhoneBook();
            pB.AddPhone("123", "Andrey");
            pB.AddPhone("124", "Bill");

            Console.WriteLine(pB.FindPhone("Andrey"));
            Console.WriteLine(pB.FindName("124"));
            Console.WriteLine();
        }
    }
}
