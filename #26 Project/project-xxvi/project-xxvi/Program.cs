using System;

namespace project_xxvi
{
    class Program
    {
        static void Main(string[] args)
        {
            // string interpolation = allows us to insert variables into a string literal
            //                        precede a string literal with $
            //                        {} are placeholders

            String firstName = "DnA";
            String lastName = "freestyle";
            int age = 16;

            //  Console.WriteLine("Hello " + firstName + " " + lastName + ".");
            //   Console.WriteLine("You are " + age + " years old.");

            Console.WriteLine($"Hello {firstName} {lastName}.");
            Console.WriteLine($"You are {age} years old");






            Console.ReadKey();
        }
    }
}