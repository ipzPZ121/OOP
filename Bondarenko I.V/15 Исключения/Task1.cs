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

            string readingStr;
            try
            {
                using (StreamReader reader = new StreamReader("file.txt"))
                {
                    readingStr = reader.ReadToEnd();

                }
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Параметр имеет значение пустой ссылки.  " + ex.Message);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Параметр содержит пустую строку. "+ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("Файл не найден.  " + ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine("Указанный путь недопустим; возможно, он соответствует неподключенному диску.  " + ex.Message);
            }
            catch (IOException ex)
            {
                Console.WriteLine("Параметр включает неверный или недопустимый синтаксис имени файла, имени каталога или метки тома.   " + ex.Message);
            }
            
            

        }
    }
}
