using System;
using System.Text;

namespace oop2 {
    class Table {
        public int length;
        public int width;
        public string material;

        public int Square() {
            return length * width;
        }

        public Table() {
            length = 0;
            width = 0;
            material = "";
        }

        public void Print()  {
            Console.WriteLine(length);
            Console.WriteLine(width);
            Console.WriteLine(material);
        }

        public int CompareTo(Table table) {
            if(Square() > table.Square())
                return 1;
            else if(Square() < table.Square())
                return -1;
            else
                return 0;
        }
    }
}
