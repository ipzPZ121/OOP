using System;
using System.Text;
using System.Collections.Generic;

namespace oop4 {
    class MyVectorArr {
        private int[] arr;
        private int currIndex;

        public MyVectorArr() {
            arr = new int[10];
            currIndex = 0;
        }

        public MyVectorArr(int[] arr) {
            this.arr = new int[arr.Length];
            Array.Copy(arr, this.arr, this.arr.Length);
        }

        public MyVectorArr(MyVectorArr vec) {
            arr = new int[vec.ToArray().Length];
            Array.Copy(vec.ToArray(), arr, arr.Length);
        }

        public MyVectorArr(Rectangle rect) : this() {
            arr = new int[4];
            arr[0] = rect.GetX();
            arr[1] = rect.GetY();
            arr[2] = rect.GetX() + rect.GetW();
            arr[3] = rect.GetY() + rect.GetH();
        }

        public int GetSize() {
            return arr.Length;
        }

        public int[] ToArray() {
            int[] tmp = new int[arr.Length];
            Array.Copy(arr, tmp, tmp.Length);
            return tmp;
        }

        public void Append(int elem) {
            if (currIndex == arr.Length - 1)
            {
                int oldSize = GetSize();
                int[] temp = new int[oldSize];
                Array.Copy(arr, temp, oldSize);
                arr = new int[GetSize() + 10];
                Array.Copy(temp, arr, oldSize);
            }
            
            arr[currIndex] = elem;
            currIndex++;
        }

        public void Insert(int elem, int index) {
            if(index >= arr.Length) {
                return;
            }
            int[] first = new int[index];
            int[] second = new int[GetSize() - index];
            Array.Copy(arr, first, first.Length);
            Array.Copy(arr, index, second, 0, second.Length);
            arr = new int[first.Length + second.Length + 1];
            Array.Copy(first, arr, first.Length);
            arr[first.Length] = elem;
            Array.Copy(second, 0, arr, index + 1, second.Length);
        }

        public void Remove(int index) {
            if (index >= arr.Length || index < 0)
            {
                return;
            }
            int[] first = new int[index];
            int[] second = new int[GetSize() - index];
            Array.Copy(arr, first, first.Length);
            Array.Copy(arr, index + 1, second, 0, second.Length - 1);
            arr = new int[first.Length + second.Length];
            Array.Copy(first, arr, first.Length);
            Array.Copy(second, 0, arr, first.Length, second.Length);
        }

        public int At(int index) {
            if (index >= arr.Length || index < 0)
            {
                return -1;
            }

            return arr[index];
        }

        public override string ToString() {
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < arr.Length; i++)
            {
                str.Append(arr[i]);
                str.Append(' ');
            }
            str.Remove(str.Length - 1, 1);
            return "[ " + str.ToString() + " ]";
        }
    }
}
