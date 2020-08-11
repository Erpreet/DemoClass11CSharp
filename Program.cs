using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare(create) a variable using the datatype followd by the name.

            string text; //Strings store text 
            char character; //stores a single character (including space, newline, etc)
            int wholeNumber; // Int stores a number without a decimal point (positive or negative) , byte, short and long are integer types with varying size limits
            double number; // Double stores a number without a decimal point // float and decimal re alternatives with quirks
            bool boolean; // Bool stores a true or false value


            Console.WriteLine("Please enter your name below"); //Tell the user what we are expecting

            string name; // DEclare a variable
            int age, birthyear;

            Console.WriteLine("Please enter your name below");
            name = Console.ReadLine();// Assign a value to variable (that we get from user)

            Console.WriteLine("Please enter your age below");
            age = int.Parse(Console.ReadLine());

            birthyear = 2020 - age;


            Console.WriteLine(name); //Retrieve value from variable and send it to console

            Console.WriteLine("Hello," +name + " . You were born in the year" +birthyear + "." );


        }
    }
}
