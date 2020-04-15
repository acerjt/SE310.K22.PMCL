using System;

namespace Generic
{
    class MyGenClass<T> {
        private T[] list;
        private int count = 0;
        public MyGenClass(int length) {
            list = new T[length];
        }

        public void Add(T element) {
            if(count < list.Length)
                list[count++] = element;
        }
        public void Display() {
            foreach(T item in list) {
                Console.Write(" {0} ", item);
            }
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyGenClass<int> a = new MyGenClass<int>(3);
            a.Add(1);
            a.Add(2);
            a.Add(3);
            Console.WriteLine("Xuat mang kieu int");
            a.Display();

            MyGenClass<string> s = new MyGenClass<string>(2);
            s.Add("Hello");
            s.Add("world");
            Console.WriteLine("Xuat mang kieu string:");
            s.Display();
        }
    }
}
