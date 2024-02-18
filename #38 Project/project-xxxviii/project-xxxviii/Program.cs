using System;

namespace project_xxxviii
{
    class Program
    {
        static void Main(string[] args)
        {
            //polymorphism

            Car car = new Car();
            Bicyle bicyle = new Bicyle();
            Boat boat = new Boat();

             Vehicle [] vehicles = { car, bicyle, boat };

            foreach(Vehicle vehicle in vehicles)
            {
                vehicle.Go();
            }

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public virtual void Go()
        { 

         }
    }
    class Car : Vehicle
    {
        public override void Go ()
        {
            Console.WriteLine("The car is moving.");
        }
    }
    class Bicyle  : Vehicle
    {
        public override void Go()
        {
            Console.WriteLine("The bike is riding.");
        }
    }
    class Boat : Vehicle
    {
    public override void Go()
        {
            Console.WriteLine("The boat is sailing");
        }
    }

}
