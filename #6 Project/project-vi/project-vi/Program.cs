using System;

namespace project_vi
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            //int num = random.Next(1, 7);                  //will generate a random number in the range of 1-6 
            //int num = random.Next(1, 7) + 100;    //range is now from 101-106
            //int num = random.Next(1, 21);             //range from 1 -21
            // double num = random.NextDouble();   //random number will be from 0-1(integer value)
            int num1 = random.Next(1, 7);
            int num2 = random.Next(1, 7);
            int num3 = random.Next(1, 7);



            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);





































            Console.ReadKey();

        }
    }
}
