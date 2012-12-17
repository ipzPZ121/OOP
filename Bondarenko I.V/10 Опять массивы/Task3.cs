using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Наш массив
            String[] strArr = {"good","morning","this","program"};

            //Создаем jagged
            char[][] jagCh;

            //Размещаем массив ссылок
            jagCh = new char[strArr.Length][];

            //Cоздаем массивы-элементы
            for (int i = 0; i < strArr.Length; i++)
            {
                string str = strArr[i];
                jagCh[i] = new char[str.Length];
                //Заселяем символы в ячейки
                
                for (int j = 0; j < str.Length; j++)
                {
                    jagCh[i][j] = str[j];
                }
            }

            foreach (var var in jagCh)
            {
                Console.WriteLine(var);
            }
        }
    }
}
