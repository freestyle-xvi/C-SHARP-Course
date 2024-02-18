using System;

namespace project_xxix
{
    class Program
    {
        static void Main(string[] args)
        {
            //objects
            //constructors

            /*
            Human human1 = new Human();
            Human human2 = new Human();
            */

            Human human1 = new Human("Phoenix",16);
            Human human2 = new Human("freestyle",21);

            /*
            human1.name = "Phoenix";
            human1.age = 16;

            human2.name = "freestyle";
            human2.age = 21;
            */

            human1.eat();
            human1.sleep();

            human2.eat();
            human2.sleep();

            ///////////////////////////////////////////////////








            Car car1 = new Car("Mazda","RX7", 1992, "Red");
            Car car2 = new Car("Nissan", "R33 GTR", 1995, "Midnight Purple");
            
            
            car1.Drive();
            car2.Drive();


            Console.ReadKey();
        }
    }
    class Human
    {
        public String name;
        public int age;

        public Human(String name , int age )
        {
            this.name = name;
            this.age = age;
        }

        public void eat()
        {
            Console.WriteLine(name + " is eating "  );
        }
        public void sleep()
        {
            Console.WriteLine(name + " is sleeping "  );
        }
    }
    class Car
    {
        String make;
        String model;
        int year;
        String color;

        public Car (String make, String model, int year, String color)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }
        public void Drive ()
        {
            Console.WriteLine("You drive the " + make + " " + model);
        }
    }
}
