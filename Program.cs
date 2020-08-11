using System;

namespace FirstDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // > 
            // <
            // >=
            //<=
            // ==
            // !=

            // &&
            // ||

            //Console.WriteLine(4 >2 && (5*4 == 22 || 8 /3 == 2));
            int age;

            Console.WriteLine("Please enter your age");
            age = int.Parse(Console.ReadLine());


            if(age >= 18)
            {
                Console.WriteLine("You are legally allowed to gamble in Alberta");
            }

            
            
            
            // Console.WriteLine("Hello".ToUpper() == "hello".ToUpper());


            
        }
    }
}
