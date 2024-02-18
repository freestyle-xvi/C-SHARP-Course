using System;

namespace project_xxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //return keyword

            double x;
            double y;
            double result;

            Console.WriteLine("Enter in first value : ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter in second value : ");
            y = Convert.ToDouble(Console.ReadLine());

            result = Multiply(x,y);

            Console.WriteLine("The answer is  " + result);

            Console.ReadKey();
        }
        static double Multiply(double x, double y)
        {

            return x * y; ;
        }
    }
}
