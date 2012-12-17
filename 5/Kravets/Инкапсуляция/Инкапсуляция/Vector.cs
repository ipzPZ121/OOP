using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Инкапсуляция
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace Объявляем_свой_тип_данных
    {
        class Vector
        {
            private LinkedList<int> arr;

            public Vector(int[] array)
            {
                arr = new LinkedList<int>(array);
            }

            public Vector(Vector v)
            {
                arr = v.arr;
            }

            public Vector()
            {
                arr = new LinkedList<int>();
            }


            public void add(int val)
            {
                arr.AddLast(val);
            }

            public int get(int i)
            {
                if (i >= 0 && i < arr.Count)
                    return arr.ElementAt(i);
                else
                    throw new System.ArgumentException("Invalid index");
            }

            public void insert(int i, int value)
            {
                if (i >= 0 && i < arr.Count) {
                    if (i > 0)
                    {
                        var ind = arr.Find(arr.ElementAt(i-1));
                        arr.AddAfter(ind, value);
                    }
                    else
                    {
                        arr.AddFirst(value);
                    }
                }
                else
                    throw new System.ArgumentException("Invalid index");
            }

            public void remove(int i)
            {
                arr.Remove(arr.Find(arr.ElementAt(i)));
            }

        }
    }

}
