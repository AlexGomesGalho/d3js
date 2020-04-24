using System;
//Write a program in C# Sharp to create a user define function
namespace UserDefinedFunctions
{
    class greeting
    {
        static void Main(string[] args)
        {
            greeting p = new greeting();
            Console.WriteLine("Please Enter Your name!");
            string name = Console.ReadLine();
            p.welcome(name);

        }

        public void welcome(string name)
        {
            
            Console.WriteLine("Welcome" +name+"Have a nice day");
        }

    }
}
