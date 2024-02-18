using System;
using System.Collections.Generic;

namespace project_xl
{
    class Program
    {
        static void Main(string[] args)
        {
            //list = data structure that represents a list of objects that can be accessed by an index.

            List<String> food = new List<String>();

            food.Add("curry"); 
            food.Add("pizza");
            food.Add("burger");
            food.Add("pasta");
            food.Add("curry");

            //Console.WriteLine(food[3]);

            //food.Remove("pasta");      //remvoves a specific item in list
            food.Insert(0, "sushi");      //inserts a specific item in list at a specif item index
            Console.WriteLine("amount of foods :  " + food.Count);
            Console.WriteLine("pasta is at item index : " + food.IndexOf("pasta"));
            Console.WriteLine("the last instance of curry in the item index : " + food.LastIndexOf("curry"));
            Console.WriteLine("is there a burger in this list of food =   "+  food.Contains("burger"));
            //food.Sort(); //sorts items in list alphabetically
            //food.Reverse();//sorts items in list in reverse of original list
            //food.Clear();//clears all items in the list

            String[] foodArray = food.ToArray();



           foreach(String item in foodArray)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
        }
    }
}
