using System;

namespace project_xxxiv
{
    class Program
    {
        static void Main(string[] args)
        {
            //array of objects

         


            Car[] garage = { new Car("AE86"), new Car("RX7"), new Car("R32-GTR") };

            //Console.WriteLine(garage[0].model);
            //Console.WriteLine(garage[1].model);
            //Console.WriteLine(garage[2].model);

            foreach(Car car in garage)
            {
                Console.WriteLine(car.model); 
            }

            Console.ReadLine();
        }
    }
    class Car
    {
        public String model;

        public Car(String model)
        {
            this.model = model;
        }
    }
}
