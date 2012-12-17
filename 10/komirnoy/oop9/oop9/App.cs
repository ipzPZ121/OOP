using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace oop9 {
    class App {
        public static void Main(string[] args) {
            float[] a = { 1.3f, 5.4f, 6.3f, 2.1f, 2.6f, 4.2f };
            int pos;
            float num;
            App.GetMaxFromArray(a, out pos, out num);

            Console.WriteLine(pos);
            Console.WriteLine(num);

            Console.WriteLine();

            int x = 2;
            int y = 4;
            App.Replace(ref x, ref y);
            Console.WriteLine(x);
            Console.WriteLine(y);

            Console.WriteLine();
        }

        public static void GetMaxFromArray(float[] arr, out int pos, out float num) {
            if (arr == null){
                pos = -1;
                num = 0f;

                return;
            }

            int index = 0;

            float[] tmp = new float[arr.Length];
            Array.Copy(arr, tmp, tmp.Length);
            Array.Sort(tmp);
            for (int i = 0; i < arr.Length; i++) {
                if (arr[i] == tmp[tmp.Length - 1]) {
                    index = i;
                }
            }
            pos = index;
            num = tmp[tmp.Length - 1];
        }

        public static void Replace(ref int a, ref int b) {
            int t = a;
            a = b;
            b = t;
        }


    }
}
