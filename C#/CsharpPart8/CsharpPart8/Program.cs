using System;
using CsharpPart8;
//default Constructor
//Parameterized constructor
namespace Constructors
{
    public class defaultC
    {
        public defaultC()
        {
            Console.WriteLine("The default constructor is being called.");
        }
        public static void Main(string[] args)
        {
            defaultC c = new defaultC();
            ParameterizedC p = new ParameterizedC(1,2);
        }
    }
}
