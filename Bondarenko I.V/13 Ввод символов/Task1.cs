using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = File.ReadAllLines("file.txt").Length;

            using (StreamReader srTxt = new StreamReader("file.txt"))
            {
                int i = 0;
                while (i < (count - 20))
                {
                    srTxt.ReadLine();
                    i++;
                }
                Console.WriteLine(srTxt.ReadToEnd());
            }

        }
    }
}
