using System;

namespace project_xviii
{
    class Program
    {
        static void Main(string[] args)
        {
            //arrays = a variable that can store multiple values. fixed size

            //String[] cars = { "GTR", "RX7", "AE86" };

            String[] cars = new string[3];

            cars[0] = "R33";
            cars[1] = "RX7";
            cars[2] = "AE86";

            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }
            













            Console.ReadKey();
        }
    }
}
