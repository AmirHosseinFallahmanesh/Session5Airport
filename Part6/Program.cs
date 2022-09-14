using System;
using System.Collections.Generic;

namespace Part6
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> myList = new MyList<string>();
            myList.Add("item");
          

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine();
            Console.WriteLine();
            List<int> list = new List<int>();
            list.Add(12);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        

        }
    }
    class MyList<T>
    {
        private T[] data;
        public MyList()
        {
            data = new T[0];
        }
        public MyList(int size)
        {
            data = new T[size];
        }

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public void Add(T item)
        {
            Array.Resize(ref data, data.Length + 1);
            data[data.Length - 1] = item;
        }

        public int Count { get => data.Length; }
    }
}
