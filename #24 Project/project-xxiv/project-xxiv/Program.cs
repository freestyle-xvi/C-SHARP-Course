using System;

namespace project_xxiv
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double result;


            try
            {
                Console.Write("Enter number 1: ");
                x = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter number 2: ");
                y = Convert.ToInt32(Console.ReadLine());

                result = x / y;

                Console.WriteLine("result: " + result);



                Console.ReadKey();
            }
     
            catch(FormatException e)
            {
                Console.WriteLine("Enter a number not a word !");
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("YOU CAN'T DIVIDE BY ZERO, IDIOT");
            }
     
            catch(Exception e)
            {
                Console.WriteLine("Something went wrong, please try again.");
            }
            finally
                {
                Console.WriteLine("Thanks for visiting, jk dont come back ever, jk g'bye");
            }
        }
    }
}
