using System;

namespace project_vii
{
    class Program
    {
        static void Main(string[] args)
        {
            //hypotenuse calculator program

            Console.WriteLine("Enter value of side A of triangle:");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter value of side B of triangle:");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt( (a * a) + (b * b) );

            Console.WriteLine("The hypotenuse of the triangle is: " + c);


































            Console.ReadKey();

        }
    }
}
