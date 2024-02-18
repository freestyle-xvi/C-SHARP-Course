using System;

namespace project_xxxvi
{
    class Program
    {
        static void Main(string[] args)
        {
            //ToString method 

            Car car = new Car("Nissan","R33-GTR", 1995, "Midnight-Purple" );

            Console.WriteLine( car);

            Console.ReadKey();
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car(String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public override string ToString()
        {
   
            return "This is a  " + make + " " + model; 
        }
    }
}
