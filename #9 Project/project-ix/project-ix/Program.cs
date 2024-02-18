using System;

namespace project_ix
{
    class Program
    {
        static void Main(string[] args)
        {
            //if statements = basic form of making decisions

            /*Console.WriteLine("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age > 100) // checks fi age is older than 100
            {
                Console.WriteLine("you're too old my guy , go sleep XD");
            }
            else if (age >= 18) //checks if age is graeter than 18
                {
                
               Console.WriteLine("You have been verified!");
            }
            else if (age < 0) //checks if age is lower than 0
                {
                Console.WriteLine("please enter a valid age");  
            }
            else
            {
                Console.WriteLine("You must be 18 years or older to be verified!");
            }

            */
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            if (name == "")
            {
                Console.WriteLine("please enter in your name");
            }
            else
            {
                Console.WriteLine("hello " + name);
            }
































            Console.ReadKey();
        }
    }
}
