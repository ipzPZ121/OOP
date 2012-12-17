using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop11 {
    class App {
        public static void Main(string[] args) {
            string[] stra = App.StringToken("Here's a good news");
            foreach (string s1 in stra) {
                Console.WriteLine(s1);
            }

            Console.WriteLine();

            string st1 = "Hello";
            string st2 = "hello";
            Console.WriteLine(App.Compare(st1, st2));

            Console.WriteLine();
        }

        public static string[] StringToken(string str) {
            return str.Split(new char[] { ' ', '.', ',', '?', '!', ':', ';', '-', '(', ')', '{', '}' });
        }

        public static int Compare(string str1, string str2) {
            int str1Len = str1.Length;
            int str2Len = str2.Length;

            int result = 0;

            str1 = str1.ToUpper();
            str2 = str2.ToUpper();

            if (str1Len < str2Len)
                result = -1;
            else if (str1Len > str2Len)
                result = 1;
            else if (str1Len == str2Len) {
                for (int i = 0; i < str1Len; i++) {
                    if (str1[i] < str2[i])
                        result += -1;
                    else if (str1[i] > str2[i])
                        result += 1;
                    else if (str1[i] == str2[i])
                        result += 0;
                }
            }

            return result;
        }
    }
}
