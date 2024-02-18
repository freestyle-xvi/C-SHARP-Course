using System;

namespace project_xlv
{
    class Program
    {
        static void Main(string[] args)
        {
            //generics

            int[] intArray = {1,2,3};
            double[] doubleArray = {1.1,2.2,3.3};
            String [] stringArray = {"-1","-2","-3"};

            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);

            Console.ReadKey();
        }
        public static void displayElements<T>(T [] array)
        {
            foreach(T item in array)
            {
                Console.WriteLine(item + " ");
            }
            Console.WriteLine( );
        }
        
    }
}
