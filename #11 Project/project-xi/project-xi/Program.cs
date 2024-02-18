using System;

namespace project_xi
{
    class Program
    {
        static void Main(string[] args)
        {
            //logical operaters
            // && (and)
            // || (or)

            Console.WriteLine("What's your cpu temps: (C)");
            double temp = Convert.ToDouble(Console.ReadLine());

            if (temp >= 40 && temp <= 75)
            {
                Console.WriteLine("your temps seems legit.");
            }
            else if (temp <= 40 ||temp >= 75)
            {
                Console.WriteLine("your temps ain't doin so well my dude, check em out.");
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
