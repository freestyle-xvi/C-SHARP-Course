using System;

namespace project_xxxi
{
    class Program
    {
        static void Main(string[] args)
        {
            //overloaded constructors can  create  objects with varying amount of fields they just have to have different parameters







            Pizza pizza = new Pizza("Stuffed crust", "tomato sauce", "mozzarella","creamy chicken");

            Console.ReadKey();
        }
    }

    class Pizza
    {
        String bread;
        String sauce;
        String cheese;
        String topping;

        public Pizza(String bread, String sauce, String cheese, String topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;

        }
        public Pizza(String bread, String sauce, String cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
           

        }
        public Pizza(String bread, String sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
        }
        public Pizza(String bread)
        {
            this.bread = bread;
        }
    }
}
