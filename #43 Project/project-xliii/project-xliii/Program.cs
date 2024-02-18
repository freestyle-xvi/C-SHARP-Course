using System;

namespace project_xliii
{
    class Program
    {
        static void Main(string[] args)
        {
            //auto implemented properties

            Car car = new Car("Subaru-Impreza-22b");

            Console.WriteLine(car.Model);

            Console.ReadKey();
        }
    }
    class Car
    {
        public String Model { get; set; }
        public Car(string model)
        {
            this.Model = model;
        }
    }
}
