using System;

namespace project_x
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What day is it today?");
            string day = Console.ReadLine();

            switch (day)
            {
                case "Monday":
                    Console.WriteLine("it's Monday");
                    break;
                case "Tuesday":
                    Console.WriteLine("it's Tuesday");
                    break;
                case "Wednesday":
                    Console.WriteLine("it's Wednesday");
                    break;
                case "Thursday":
                    Console.WriteLine("it's Thursday");
                    break;
                case "Friday":
                    Console.WriteLine("it's Friday");
                    break;
                case "Saturday":
                    Console.WriteLine("it's Saturday");
                    break;
                case "Sunday":
                    Console.WriteLine("it's Sunday");
                    break;
                default:
                    Console.WriteLine(day + " is not a day");
                        break;
            }










            Console.ReadKey();
        }
    }
}
