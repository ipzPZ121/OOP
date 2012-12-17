using System;
using System.Collections.Generic;

namespace TestConsole
{
    class CompSortL : IComparer<string>
    {
        
        public int Compare(string s1, string s2)
        {
            int minLenght = s1.Length < s2.Length ? s1.Length : s2.Length;
            int comp = String.Compare(s1, s1.Length - 1, s2, s2.Length - 1, 1);

            if (comp == 0)
            {
                for (int i = 2; i < minLenght; i++)
                {
                    comp = String.Compare(s1, s1.Length - i, s2, s2.Length - i, 1);
                    if (comp != 0)
                    {
                        break;
                    }
                }
            }

            return comp;

        }

    }

    class Program
    {
       
        static void Main(string[] args)
        {
            SortedList<string, string> tolkDictionary = new SortedList<string, string>(new CompSortL());

            tolkDictionary.Add("Яблоко","фрукт с дерева");
            tolkDictionary.Add("Малина", "ягода растет на кусте");
            tolkDictionary.Add("Апельсин", "цитрусовый фрукт");
            tolkDictionary.Add("Ворона", "черная птица");
            tolkDictionary.Add("Голубь", "городская птица");
            tolkDictionary.Add("Хомяк", "мелкий грызун");
            tolkDictionary.Add("Вода", "H2O");
            tolkDictionary.Add("Покер", "карточная игра");
            tolkDictionary.Add("Футбол", "игровой вид спорта");

            foreach (var key in tolkDictionary.Keys)
            {
                Console.WriteLine("{0} : {1}", key, tolkDictionary[key]);
            }
        }
    }
}
