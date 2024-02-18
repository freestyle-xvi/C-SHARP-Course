using System;

namespace project_xxxii
{
    class Program
    {
        static void Main(string[] args)
        {

            //inheritance

            Car car = new Car();
            Bicyle bicyle = new Bicyle();
            Boat boat = new Boat();

            Console.WriteLine(car.speed);
            Console.WriteLine(car.wheels);
            car.go();

            Console.WriteLine(bicyle.speed);
            Console.WriteLine(bicyle.wheels);
            bicyle.go();

            Console.WriteLine(boat.speed);
            Console.WriteLine(boat.wheels);
            boat.go();
            

            Console.ReadKey();
        }
    }
    class Vehicle
    {
        public int speed = 0;
        public void go()
        {
            Console.WriteLine("This vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
    }
    class Bicyle : Vehicle
    {
        public int wheels = 2;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
    }
}
