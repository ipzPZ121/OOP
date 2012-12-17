using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace oop13 {
    class App {
        public static void Main(string[] args) {
            using(ArrayReader arrReader = new ArrayReader(new char[]{'H', 'e', 'l', 'l', 'o', '\n', 'w', 'o', 'r', 'l', 'd', '\r', '\n'})) {
                string text4 = arrReader.ReadLine();
                Console.WriteLine(text4);
                string text5 = arrReader.ReadLine();
                Console.WriteLine(text5);
                string text6 = arrReader.ReadToEnd();
                Console.WriteLine(text6);
            }

            Console.WriteLine();

            App.SortString("file1.txt", "out.txt");

            Console.WriteLine();

            char[] ch1 = {'H', 'e', 'l', 'l', 'o', '\n', 'w', 'o', '\r', 'r', 'l', 'd', ' ', 'a', 'n', 'd', ' '};
            char[] ch2 = {'H', 'e', 'l', 'l', 'o', '\n', 'w', 'o', 'r', 'l', 'd'};
            char[] ch3 = null;
            using(ArrayWriter tWr = new ArrayWriter()) {
                tWr.Write(ch1);
                tWr.WriteLine(ch2);
                Console.WriteLine(tWr.Text);
                Console.WriteLine();
                try {
                 tWr.Write(ch3);
                } catch(MyException myExp) {
                    Console.WriteLine(myExp.Message);
                }

            }

            Console.WriteLine();

            MyBigInteger bigInt1 = new MyBigInteger("45647546768465354");
            MyBigInteger bigInt2 = new MyBigInteger("125646545634543543354534354343");
            MyBigInteger bigInt3 = bigInt1.Sum(bigInt2);
            Console.WriteLine(bigInt3.Number);
            Console.WriteLine();
            MyBigInteger bigInt4 = bigInt1.Sub(bigInt2);
            Console.WriteLine(bigInt4.Number);

            Console.WriteLine();
        }

        public static string[] SortString(string fileNameIn, string fileNameOut) {
            int size = 0;

            try {
                using(TextReader reader = new StreamReader(fileNameIn)) {
                    while(reader.ReadLine() != null) {
                        size++;
                    }
                }
            } catch(FileNotFoundException fNFExp) {
                Console.WriteLine(fNFExp.Message);
            }

            string[] strs = new string[size];

            try {
                using(TextReader reader = new StreamReader(fileNameIn)) {
                    string str;
                    for(int i = 0; (str = reader.ReadLine()) != null; i++) {
                        strs[i] = str;
                    }
                }
            } catch(FileNotFoundException fNFExp) {
                Console.WriteLine(fNFExp.Message);
            }

            for(int i = 0; i < strs.Length; i++) {
                for(int j = 0; j < strs.Length - 1; j++) {
                    if(strs[j].CompareTo(strs[j + 1]) > 0) {
                        string s = strs[j];
                        strs[j] = strs[j + 1];
                        strs[j + 1] = s;
                    }
                }
            }

            using(TextWriter writer = new StreamWriter(fileNameOut, false)) {
                foreach(string s in strs) {
                    writer.WriteLine(s);
                }
            }

            return strs;
        }
    }
}
