using System;

namespace Part3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 100; i++)
            {
                MC mc = MC.Create();
            }
        }
    }
    class MC
    {
        static int counter = 0;

        public static MC Create()
        {
            if (counter<10)
            {
                return new MC();
            }
            return null;
        }
        private MC()
        {
            counter++;
            Console.WriteLine("object Created");
        }
    }
}
