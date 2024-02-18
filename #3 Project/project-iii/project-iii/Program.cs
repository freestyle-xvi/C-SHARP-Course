using System;

namespace project_iii
{
    class Program
    {
        static void Main(string[] args)
        {
            //user inputs
            Console.WriteLine("What's your name?");//ask's user to input name
            string name = Console.ReadLine();//user inputs name

            Console.WriteLine("\nWhat's your age?");//ask's user to input age
            int age = Convert.ToInt32(Console.ReadLine());  //user inputs age //also converts the input to an int   

            Console.WriteLine("\n" + "hello " + name );
            Console.WriteLine("Your age is " + age + " years old");













































            Console.ReadKey();
        }
    }
}
