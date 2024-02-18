using System;

namespace project_xix
{
    class Program
    {
        static void Main(string[] args)
        {
            //foreach loop = a simpler way to iterate over an array, but it's less fexible

            String[] cars = { "GTR", "RX7", "AE86" };
            foreach(String car in cars)
            {
                Console.WriteLine(car);
            }
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
