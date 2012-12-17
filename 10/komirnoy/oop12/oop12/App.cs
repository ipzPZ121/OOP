using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace oop12 {
    class App {
        public static void Main(string[] args) {
            Table t = new Table();
            t.Length = 150;
            t.Width = 100;
            t.Material = "пластик";

            t.Print();

            Table t2 = new Table();
            t2.Length = 150;
            t2.Width = 100;
            t2.Material = "пластик";

            int compare = t.CompareTo(t2);
            Console.WriteLine(compare);

            Console.WriteLine();

            Console.WriteLine(t.Equals(t2));
            Console.WriteLine(t2.Equals(t));
            Console.WriteLine(t.GetHashCode());
            Console.WriteLine(t2.GetHashCode());

            Console.WriteLine();

            Type tableType = Table.GetTypeClass();
            ConstructorInfo constr = null;
            MethodInfo[] methods;
            PropertyInfo proper = null;
            if(tableType != null) {
                constr = tableType.GetConstructor(new Type[]{});
                object obj = constr.Invoke(new object[] {});
                if(obj != null) {
                    proper = tableType.GetProperty("Length");
                    if(proper != null) {
                        MethodInfo setM = proper.GetSetMethod();
                        setM.Invoke(obj, new object[]{121});
                    }
                }
                Table ttt = obj as Table;
                Console.WriteLine(ttt.Length);

                methods = tableType.GetMethods();
                foreach(MethodInfo m in methods) {
                    Console.WriteLine(m.Name);
                    Console.WriteLine(m.ReturnType);
                    Console.WriteLine("Static: {0}", m.IsStatic);
                    Console.WriteLine("Virtual: {0}", m.IsVirtual);
                    Console.WriteLine("Private: {0}", m.IsPrivate);
                    Console.WriteLine("Public: {0}", m.IsPublic);
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
        }
    }
}
