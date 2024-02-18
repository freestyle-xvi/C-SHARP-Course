using System;

namespace project_xxxvi
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overloading

            Dog dog = new Dog();
            Cat cat = new Cat();

            dog.Speak();
            cat.Speak();

            Console.ReadLine(); 
        }
    }
    class Animal
    {
        public virtual void Speak()
        {
            Console.WriteLine("The animal goes *brrrrrrrrrrrrrr*");
        }
    }
    class  Dog : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The dog goes *woof*");
        }

    }
    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("The cat goes *meow*");
        }



    }
}
