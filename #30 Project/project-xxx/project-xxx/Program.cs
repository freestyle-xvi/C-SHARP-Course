using System;

namespace project_xxx
{
    class Program
    {
        static void Main(string[] args)
        {
            //static

            Car car1 = new Car("RX7-FD");
            Car car2 = new Car("AE86");
            Car car3 = new Car("R33-GTR");


            Console.WriteLine(Car.numberOfCars);

            Car.StartRace();

            Console.ReadKey();
        }
    }
    class Car
    {
        String model;
       public static int numberOfCars;

        public Car(String model)
        {
            this.model = model;
            numberOfCars++;
        }
        public static void StartRace()
        {
            Console.WriteLine("The race has begun! ");
        }



    }
}
