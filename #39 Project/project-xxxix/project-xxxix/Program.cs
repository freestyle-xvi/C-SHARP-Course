using System;

namespace project_xxxix
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface = they define a "contract" that all the classes inheriting from should follow
            //             An interface declares "what a class should have"
            //             An inheriting class defines "how it should do it"
            //             Benefit = security + multiple inheritance + "plug-and-play"

            Rabbit rabbit = new Rabbit();
            rabbit.Flee();

            Hawk hawk = new Hawk();
            hawk.Hunt();

            Fish fish = new Fish();
            //fish.Hunt();
            fish.Flee();

            Console.ReadKey();
        }
    }
    interface IPrey
    {
        void Flee();
    }
    interface IPredator
    {
        void Hunt();
    }
    class Rabbit : IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The rabbit runs away.");
        }
    }
    class Hawk : IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is now hunting.");
        }
    }
    class Fish : IPrey, IPredator
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away.");
        }
        public void Hunt()
        {
            Console.WriteLine("The fish is now hunting.");
        }
    }
}
