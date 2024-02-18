using System;

namespace project_ii
{
    class Program
    {
        static void Main(string[] args)
        {

            //variables

            //requires a declaration and initialization
            //numbers will use : int x(name of the variable itself)

            int x; //declaration
            x = 34;//initialization
            int y = 35;//doing both steps in one
            int z = x + y;
            Console.WriteLine(x);        
            Console.WriteLine(y);            
            Console.WriteLine(z);

            int age = 16;
            Console.WriteLine("\n" + "Your age is " + age  + " years old"); // int = whole number

            double height = 169.75;//double = decaimal number
            Console.WriteLine("Your height is " + height + "cm");

            bool happy = false;// bool  = either true or false
            Console.WriteLine("Are you happy? " + happy);

            char symbol = '$';// char = single character
            Console.WriteLine("Your symbol is " + symbol);

            String name = "freestyle";//string = series of charcters(basically just a word)
            Console.WriteLine("My gamertag is " + name);

            String alias = name +  age  ;
            Console.WriteLine("Your online alias will be : " + alias);

            //constants are immutable values which are known at compile time and do not change for the life of the program

            const double pi = 3.14159; // makes it so that the variable can't be changed after you have declared it
            Console.WriteLine("\n" + pi);

            //type casting is used to convert a value to a different data type
            //useful for accepting user input (string)
            //diff data types can do different things

            double a = 3.14;
            int b = Convert.ToInt32(a); //converting a double to an integer
            Console.WriteLine("\n" + b);
            Console.WriteLine(b.GetType());//get type tells you what variable it is

            int c = 123;
            double d = Convert.ToDouble(c) + 0.1;
            Console.WriteLine("\n"+d);
            Console.WriteLine(d.GetType());

            int e = 321;
            string f = Convert.ToString(e);
            Console.WriteLine("\n" + f);
            Console.WriteLine(f.GetType());

            string g = "@";
            char h = Convert.ToChar(g);
            Console.WriteLine("\n" + h);
            Console.WriteLine(h.GetType());

            string i = "true";
            bool j = Convert.ToBoolean(i);
            Console.WriteLine("\n" + j);
            Console.WriteLine(j.GetType());


            Console.ReadKey();
        }
    }
}
