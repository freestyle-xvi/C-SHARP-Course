using System;

namespace project_xlii
{
    class Program
    {
        static void Main(string[] args)
        {
            //getters and setters

            Car car = new Car(400);

            car.Speed = 2169420;

            Console.WriteLine(car.Speed);

            Console.ReadKey();
        }
    }
    class Car
    {
        public int speed;

        public Car(int speed)
        {
            Speed = speed;
        }
        public int Speed
        {
            get { return speed; } // read whatever value that is in our field
            set                   //writable
            {
                if (value > 500)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
              
            }
        }
    }
}
