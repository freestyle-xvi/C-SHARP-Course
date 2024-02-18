using System;

namespace project_xxvii
{
    class Program
    {
        static void Main(string[] args)
        {
            //String[] mazda = { "RX7 -FD", "RX7-FC", "RX8"};
            //String[] nisssan = { "R33", "R34", "R35"};
            //String[] toyota = { "AE88", "SUPRA", "CHASER"};

            String[,] parkingLot = { { "RX7-FD", "RX7-FC", "RX8" } , //2d array has rows and columns
                                                     { "R33", "R34", "R35" },
                                                     { "AE85", "SUPRA", "GT86" } };

            parkingLot[0, 2] = "MX5-MIATA"; // changes value in first column and in the 3rd row
            parkingLot[2,0] = "AE86";              //changes value in the third colum in the first row



            /*foreach (String car in parkingLot)
            {
                Console.WriteLine(car);
            }
            */

            for(int i =0; i < parkingLot.GetLength(0); i ++)
            {
                for (int j = 0; j < parkingLot.GetLength(1); j++)
                {
                    Console.Write(parkingLot[i , j] + " " );
                }
                Console.WriteLine(""); 
            }













            Console.ReadKey();
        }
    }
}
