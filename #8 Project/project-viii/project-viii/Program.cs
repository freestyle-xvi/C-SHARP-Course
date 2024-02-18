using System;

namespace project_viii
{
    class Program
    {
        static void Main(string[] args)
        {
            //string methods 

            String fullName = "freestyle XVI";
            String phoneNumber = "021-069-0420";

            //fullName = fullName.ToUpper();      //changes all characters in string to uppercase
            //fullName = fullName.ToLower();      //changes all characters in string to lowercase
            //Console.WriteLine(fullName);

            //phoneNumber =  phoneNumber.Replace("-","/");         //replaces all "-" with "/"
            //Console.WriteLine(phoneNumber);

            //string userName = fullName.Insert(0, "@");  //inserts an @ sign at the star of the fullname     
            //Console.WriteLine(userName);

            //Console.WriteLine(fullName.Length); //displays the lenght of the string

            string firstName = fullName.Substring(0,1);//copies certain letters out of a string using the index
            string lastName = fullName.Substring(10,3);
            Console.WriteLine(firstName + "-" + lastName);

            















































            Console.ReadKey();
        }
    }
}
