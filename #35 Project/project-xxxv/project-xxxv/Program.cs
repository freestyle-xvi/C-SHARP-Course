using System;

namespace project_xxxv
{
    class Program
    {
        static void Main(string[] args)
        {
            //objects as arguments

            Car car1 = new Car("RX7-FD", "yellow");

            Car car2 = Copy(car1);
    

            Console.WriteLine(car2.color + " " +  car2.model);

            Console.ReadLine();
        } 
        public static Car Copy(Car car )
        {
            return new Car(car.model, car.color);
        }
    }
    class Car
    {
        public String model;
        public String color;

        public Car(String model, String color)
        {
            this.model = model;
            this.color = color;
        }
    }
}
