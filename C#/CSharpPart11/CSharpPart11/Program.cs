using System;
using System.Collections;

namespace DelegatesExample1
{
    class SimpleExample
    {
        public delegate void HellodelegateExample(String Message);
        static void Main(string[] args)
        {
            HellodelegateExample HL = new HellodelegateExample(hello);
            HL("This is an Example for delegates") ;
        }

        public static void hello(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}