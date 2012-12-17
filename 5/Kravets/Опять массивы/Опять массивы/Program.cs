using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Опять_массивы
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public string getId(int searchedVal, params int[][] arr)
        {
            string id = null;

            for (int i = 0; i < arr.Length; i++)
            {
                Array.BinarySearch(arr[i], searchedVal);
                if (searchedVal >= 0)
                {
                    id = "Cords of value is: " + i + " " + searchedVal;
                }
            }
            if (id == null)
                id = "Value not found";
            return id;

        }
    }
}
