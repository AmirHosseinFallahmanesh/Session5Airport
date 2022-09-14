using System;

namespace Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                MC mc = new MC();
            }

            Console.WriteLine("Instance Count "+MC.counter);
  
        }
    }

    class MC
    {
    
       public int c;
       public int b;
       public static int counter=0;
        public MC()
        {
            counter++;
        }
    }
}
