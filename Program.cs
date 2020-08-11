using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare(create) a variable using the datatype followd by the name.
            
            string name; 
            Console.WriteLine("Please enter your name below"); //Tell the user what we are expecting

            name = Console.ReadLine();// Assign a value to variable (that we get from user)


            Console.WriteLine(name); //Retrieve value from variable and send it to console

            Console.WriteLine("Hello," +name);

        }
    }
}
