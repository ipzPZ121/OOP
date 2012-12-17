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
            string words = "This is a list of words, with: a bit of punctuation" +
                        "\tand a tab character.";

            string[] split = words.Split(new Char[] { ' ', ',', '.', ':', '\t' });

            foreach (string s in split)
            {

                if (s.Trim() != "")
                    Console.WriteLine(s);
            }

        }
    }
}
