﻿using System;

namespace project_xxxiii
{
    class Program
    {
        static void Main(string[] args)
        {
            //abstract classes = modifiers that indicate missing components or incomplete implementation

            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Boat boat = new Boat();
            Vehicle vehicle = new Vehicle();




            Console.ReadLine();
        }
    }
   abstract  class Vehicle                                              //ABSTRACT WILL NOW NOT ALLOW YO U TO USE THAT CLASS AS IT IS INCOMPLETE 
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("The vehicle is moving!");
        }
    }
    class Car : Vehicle
    {
        public int wheels = 4;
        int maxSpeed = 500;
    }
    class Bicycle  : Vehicle
    {
        public int wheels = 2;
        int maxSpeed = 50;
    }
    class Boat : Vehicle
    {
        public int wheels = 0;
        int maxSpeed = 100;
    }
}
