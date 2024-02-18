using System;

namespace project_xxii
{
    class Program
    {
        static void Main(string[] args)
        {
            //method overloading
            //methods can have the same name but their parameters have to be different

            double total;

            total = Multiply(2, 3, 4);

            Console.WriteLine(total);
            
            Console.ReadKey();
        }
        static double Multiply(double a , double b)
        {
            return a * b;
        }
        static double Multiply(double a, double b, double c)
        {
            return a * b * c;
        }
    }
}
