using System;
using System.Collections.Generic;
using System.Linq;

namespace Part5
{
    //0 cs   1 java  2 asp 3 sql
    class Program
    {
        static void Main(string[] args)
        {
           
            Student student = new Student(4);
            student[Courses.CSharp] = 12.2;
            student[Courses.Asp] = 18.8;
            student[Courses.Sql] = 16.6;
            student[Courses.DDD] = 14.4;
         
            Console.WriteLine("the average is "+student.GetAverage());

        }

        class Student
        {
            private double[] marks;
            public Student(int markCount)
            {
                marks = new double[markCount];
            }
            public double this[Courses index]
            {
                get { return marks[(int)index]; }
                set { marks[(int)index] = value; }
            }

            public double GetAverage() => marks.Sum() / marks.Length;
        }
    }
}
