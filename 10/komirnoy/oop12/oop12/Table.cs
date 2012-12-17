using System;
using System.Text;

namespace oop12 {
    class Table {
        private int length;
        private int width;

        public int Length {
            get{ return length; }
            set{ length = value > 0 ? value : 0; }
        }

        public int Width {
            get{ return width; }
            set{ width = value > 0 ? value : 0; }
        }

        public string Material {
            get;
            set;
        }

        public int Square {
            get { return Length * Width; }
        }

        public Table()
            : this(0, 0, string.Empty) {
        }

        public Table(int l, int w, string m) {
            Length = l;
            Width = w;
            Material = m;
        }

        public Table(Table t)
            : this(t.Length, t.Width, t.Material) {
        }

        public void Print()  {
            Console.WriteLine(Length);
            Console.WriteLine(Width);
            Console.WriteLine(Material);
        }

        public int CompareTo(Table table) {
            if(Square > table.Square)
                return 1;
            else if(Square < table.Square)
                return -1;
            else
                return 0;
        }

        public override bool Equals(object obj) {
            Table tmp = obj as Table;
            return (tmp.Length == Length)
                && (tmp.Width == Width)
                && (tmp.Material.Equals(Material, StringComparison.CurrentCultureIgnoreCase));
        }

        public override int GetHashCode() {
            int hash = 0;
            foreach(char ch in Material) {
                hash += (int)ch;
            }
            hash += Length;
            hash += Width;
            hash *= Material.Length;

            return hash;
        }

        public static string GetClassName() {
            return "oop12.Table";
        }

        public static Type GetTypeClass() {
            return Type.GetType(Table.GetClassName());
        }
    }
}
