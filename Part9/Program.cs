using System;

namespace Part9
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker()
            {
                Age = 12,
                BaseSalary = 200,
                EmployeeCode = "",
                Name = "",
                Password = "",
                Username = "",
                WorkExprince = ""
            };


            Manager manager = new Manager()
            {
                Age = 12,
                Salary = 200,
                EmployeeCode = "",
                Name = "",
                Password = "",
                Username = "",
                Level = 1,
                Segment = ""

            };
        }
    }
    public class Employee
    {
        public string EmployeeCode { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
    }

    class Worker:Employee
    {
        
      
        public string WorkExprince { get; set; }
        public double BaseSalary { get; set; }
    }

    class Manager:Employee
    {
      
       
     
        public string Segment { get; set; }
        public int Level { get; set; }
        public double Salary { get; set; }
    }
}
