using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Объявляем_свой_тип_данных
{
    class Vector
    {
        private int[] arr = new int[0];
        
        public Vector(int[] array) {
            arr = array;
        }

        public Vector(Vector v)
        {
            arr = v.arr;
        }

        public Vector()
        {
        }


        public void add(int val) 
        {
            Array.Resize<int>(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = val;
        }

        public int get(int i)
        {
            if (i >= 0 && i < arr.Length)
                return arr[i];
            else
                throw new System.ArgumentException("Invalid index");
        }

        public void insert(int i, int value)
        {
            if (i >= 0 && i < arr.Length)
                arr[i]=value;
            else
                throw new System.ArgumentException("Invalid index");
        }

        public void remove(int i)
        {
            List<int> list = new List<int>(arr);
            list.Remove(arr[i]);
            arr = list.ToArray();
        }

    }
}
