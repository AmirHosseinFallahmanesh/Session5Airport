using System;

namespace Part7
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child();
            child.A = 20;
            child.B = 30;
            child.C= 40;
            child.DoIt();
        }
    }

    class Fahter
    {

        public int A { get; set; }
        public int B { get; set; }

        public void DoIt()
        {
            Console.WriteLine("This is father Method");
        }
    }

    class Child : Fahter
    {
        public int C { get; set; }
    }
}
