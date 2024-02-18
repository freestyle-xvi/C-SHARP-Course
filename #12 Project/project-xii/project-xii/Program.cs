using System;

namespace project_xii
{
    class Program
    {
        static void Main(string[] args)
        {
            //while loops = repeats code when conditions are true

            
            string name = "";

            while(name == "")
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }





            Console.WriteLine("hello " + name);

            
            
            
            
            
            
            
            
            Console.ReadKey();
        }
    }
}
