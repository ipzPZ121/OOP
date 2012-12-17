using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop10 {
    class App {
        public static void Main(string[] args) {
            string[] st = { "Привет", "Мир" };
            char[][] carr = App.StringToCharArray(st);
            for (int i = 0; i < st.Length; i++) {
                for (int j = 0; j < carr[i].Length; j++) {
                    Console.Write(carr[i][j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine();

            int[,] arr2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 }, { 9, 10, 11, 12 } };
            int x1, y1;
            App.GetPosition(arr2, 8, out x1, out y1);
            Console.WriteLine(x1);
            Console.WriteLine(y1);

            Console.WriteLine();
        }

        public static char[][] StringToCharArray(string[] strs) {
            char[][] arr = new char[strs.Length][];

            for (int i = 0; i < strs.Length; i++) {
                arr[i] = strs[i].ToCharArray();
            }

            return arr;
        }

        public static void GetPosition(int[,] arr, int val, out int i, out int j) {
            i = (val - 1) / arr.GetLength(1);
            j = val - (arr[0, 0] + arr.GetLength(1) * i);
        }
    }
}
