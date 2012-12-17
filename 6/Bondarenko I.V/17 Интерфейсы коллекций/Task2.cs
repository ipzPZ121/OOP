using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface IStack
    {
        object Peek(); //возвращает объект с конца коллекции но не удаляет его
        object Pop(); //возвращает объект с конца коллекции и удаляет его
        void Push(object o); //добавляет элемент в конец коллекции

    }

    interface IQueue
    {
        object Peek(); //Возвращает элемент с начала коллекции но не удаляет его
        object Dequeue(); //Возвращает объект с начала коллекции и удаляет его
        void Enqueue(object o);//Добавляет элемент в конец коллекции

    }

    class MyStack:ArrayList, IStack
    {
        

        public object Peek()
        {
            return this[this.Count - 1];
            
        }
        public object Pop()
        {
            object xOb;
            xOb = this[this.Count - 1];
            this.RemoveAt(this.Count - 1);
            return xOb;
        }
        public void Push(object o)
        {
            this.Add(o);
        }

 
    }

    class MyQueue : ArrayList, IQueue
    {
        

        public object Peek()
        {
            return this[0];
        }
        public object Dequeue()
        {
            object x = this[0];
            this.RemoveAt(0);
            return x;


        }
        public void Enqueue(object o)
        {
            this.Add(o);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаем стэк.");
            MyStack mst = new MyStack();

            mst.Push(1);
            mst.Push(2);
            mst.Push(3);
            mst.Push(4);
            mst.Push(5);
            Console.WriteLine("Заполнили стэк элементами:");
            foreach (var el in mst)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Возвращаем и удаляем: " + mst.Pop());
            Console.WriteLine("Возвращаем и удаляем: " + mst.Pop());
            Console.WriteLine("Возвращаем но не удаляем: " + mst.Peek());

            Console.WriteLine("В стэке осталось:");
            foreach (var el in mst)
            {
                Console.Write(el + " ");
                
            }

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();



            Console.WriteLine("Создаем очередь.");
            MyQueue mqu = new MyQueue();

            mqu.Enqueue(1);
            mqu.Enqueue(2);
            mqu.Enqueue(3);
            mqu.Enqueue(4);
            mqu.Enqueue(5);
            Console.WriteLine("Заполнили очередь элементами:");
            foreach (var el in mqu)
            {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Возвращаем и удаляем: " + mqu.Dequeue());
            Console.WriteLine("Возвращаем и удаляем: " + mqu.Dequeue());
            Console.WriteLine("Возвращаем но не удаляем: " + mqu.Peek());

            Console.WriteLine("В очереди осталось:");
            foreach (var el in mqu)
            {
                Console.Write(el + " ");

            }
            Console.WriteLine();
        }
    }
}
