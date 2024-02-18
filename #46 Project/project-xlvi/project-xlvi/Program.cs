using System;
using System.Threading;

namespace project_xlvi
{
    class Program
    {
        static void Main(string[] args)
        {
            //multithreading

            Thread mainThread = Thread.CurrentThread;

            mainThread.Name = "Main Thread XVI";

           // Console.WriteLine(mainThread.Name);

            Thread thread1 = new Thread(() => countDown("Timer number 1"));
            Thread thread2 = new Thread(() => countUp("Timer number 2"));

            thread1.Start();
            thread2.Start();

            Console.WriteLine(mainThread.Name + " is complete");


            Console.ReadKey();
        }
        public static void countDown(String name)
        {
            for(int i = 10; i >= 0; i-- )
            {
                Console.WriteLine("Timer number 1 : " + i + " seconds");
                Thread.Sleep(1000);//1000 milliseconds = 1 second
            }
            Console.WriteLine("\nTimer number 1 is complete!");
        }
        public static void countUp(String name  )
        {
            for (int i = 0; i <= 10; i++    )
            {
                Console.WriteLine("Timer number 2 : " + i + " seconds");
                Thread.Sleep(1000);//1000 milliseconds = 1 second
            }
            Console.WriteLine("\nTimer number 2 is complete!");
        }
    }
}
