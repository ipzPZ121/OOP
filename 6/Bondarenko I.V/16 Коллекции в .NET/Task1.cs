using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IList list1 = new ArrayList();
            list1.Add("Hello, ");
            list1.Add("my ");
            list1.Add("dear ");
            list1.Add("old ");
            list1.Add("friend! ");

            IList list2 = new ArrayList();
            list2.Add("my ");
            list2.Add("dear ");
            list2.Add("old ");

            foreach (var value in list2)
            {
                while (list1.Contains(value))
                {
                    list1.Remove(value);
                }
            }

            foreach (var v in list1)
            {
                Console.Write(v);
            }



        }
    }
}
