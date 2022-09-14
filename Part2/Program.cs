using System;

namespace Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Product invalidProduct = new Product("",-5);
            Product invalidProduct = Product.Create("", -5);
            //Product product = new Product("", -5); use factory
            if (invalidProduct==null)
            {
                Console.WriteLine("Operation Failed");
            }
        }
    }

    class Product
    {

        public static Product Create(string name, double price)
        {
            if (string.IsNullOrEmpty(name) )
            {
                return null;
            }
            if (price < 0)
            {
                return null;
            }
            return new Product(name, price);
        }
        private Product( string name, double price)
        {

            this.Name = name;
            this.Price = price;
           
        }

        public int Id { get; set; }
        public  string Name { get; set; }
        public  double Price { get; set; }
    }
}
