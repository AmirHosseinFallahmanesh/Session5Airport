using System;

namespace Part8
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Eat();

            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            BabyDog babyDog = new BabyDog();
            babyDog.Eat();
            babyDog.Bark();
            babyDog.Cry();
        }
    }
    class Animal
    {

     
      public void Eat()
        {
            Console.WriteLine("I am Eating");
        }

    }

    class Dog:Animal
    {
        public void Bark()
        {
            Console.WriteLine("I am Barking");
        }
    }

    class BabyDog:Dog
    {
        public void Cry()
        {
            Console.WriteLine("I am Crying");
        }
    }

}
