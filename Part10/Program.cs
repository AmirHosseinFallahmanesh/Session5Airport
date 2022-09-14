using System;

namespace Part10
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
    class Father
    {
        private int a;

        public int A
        {
            get { return a; }
            set { a = value; }
        }

    }
    class Child:Father
    {
        public Child()
        {
            A = 12;
        }
    }
}
