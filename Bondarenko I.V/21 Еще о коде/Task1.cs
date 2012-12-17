using System;
using System.Collections.Generic;

namespace TestConsole
{
    /// <summary>
    /// Класс реализующий интерфейс System.Collections.Generic.IComparer<T> для сравнения строк
    /// по окончаниям
    /// </summary>
    class CompSortL : IComparer<string>
    {
        /// <summary>
        /// Реализуем интерфейс IComparer<T>
        /// </summary>
        /// <param name="s1">Строка для сравнения</param>
        /// <param name="s2">Строка для сравнения</param>
        /// <returns>возвращает -1, если s1<s2; 0, если s1==s2; 1,если s1>s2</returns>
        public int Compare(string s1, string s2)
        {
            /// <summary>
            /// Минимальная длинна из 2х строк
            /// </summary>
            int minLenght = s1.Length < s2.Length ? s1.Length : s2.Length;
            /// <summary>
            /// Результат сравнения 2х строк
            /// </summary>
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
            //создаем словарь который будет сортировать слова по окончаниям
            SortedList<string, string> tolkDictionary = new SortedList<string, string>(new CompSortL());

            //добавляем в словарь данные
            tolkDictionary.Add("Яблоко","фрукт с дерева");
            tolkDictionary.Add("Малина", "ягода растет на кусте");
            tolkDictionary.Add("Апельсин", "цитрусовый фрукт");
            tolkDictionary.Add("Ворона", "черная птица");
            tolkDictionary.Add("Голубь", "городская птица");
            tolkDictionary.Add("Хомяк", "мелкий грызун");
            tolkDictionary.Add("Вода", "H2O");
            tolkDictionary.Add("Покер", "карточная игра");
            tolkDictionary.Add("Футбол", "игровой вид спорта");

            //Выводим на консоль данные в словаре
            foreach (var key in tolkDictionary.Keys)
            {
                Console.WriteLine("{0} : {1}", key, tolkDictionary[key]);
            }
        }
    }
}
