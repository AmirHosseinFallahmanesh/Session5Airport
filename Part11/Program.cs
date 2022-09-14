using System;

namespace Part11
{
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child("amir");
            Console.WriteLine(child.Name);
        }
    }
    class Father
    {
        string name;
        public Father(string name)
        {
            this.name = name;
            Console.WriteLine("this is father ctor");
        }
        public string Name { get=>name;  }
    }
    class Child:Father
    {
        public Child(string  name):base(name)
        {
            Console.WriteLine("this is child ctor");
        }
    }
}
