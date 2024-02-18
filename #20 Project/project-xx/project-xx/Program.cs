using System;

namespace project_xx
{
    class Program
    {
            static void Main(string[] args)
                {
            // method  = performs a section of code, whenever it's called invoked.
            //           benefit = Let's us reuse code w/o writing it multiple times
            //           Good practice is to capitalize method names



                    String name = "Phoenix";
            int age = 21;

                     SingHappyBirthday(name, age);

                     Console.ReadKey();
                }

                static void SingHappyBirthday(String name, int age)//parameters are needed to take variables from main method
                {
            Console.WriteLine("Happy BIrthday to you!");
            Console.WriteLine("Happy BIrthday to you!");
            Console.WriteLine("Happy BIrthday dear" + name);
            Console.WriteLine("You are " + age + " years old");
            Console.WriteLine("Happy BIrthday to you!");
            Console.WriteLine();




       
                    }
    }
}
