using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    static class TreeInFile
    {



        public static void WriteTree(string dirName, string indent)
        {
            using (StreamWriter writer = new StreamWriter("tree.txt", true, Encoding.GetEncoding(1251)))
            {
                const string STEP = " ";
                foreach (string path in Directory.GetFiles(dirName))
                {
                    writer.Write(indent);
                    writer.WriteLine(Path.GetFileName(path));
                }
                foreach (string path in
                    Directory.GetDirectories(dirName))
                {
                    writer.Write(indent);
                    writer.WriteLine(Path.GetFileName(path));
                    WriteTree(path, indent + STEP);
                }
            }
        }
    }
}
