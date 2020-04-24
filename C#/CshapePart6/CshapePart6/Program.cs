using System;
using CshapePart6;
namespace FunctionsExample
{
    class Program
    {
        
        public void Show()  
        {
            Console.WriteLine("This is non parameterized function");
         
        }  
        static void Main(string[] args)
        {
            Program program = new Program();  
            program.Show();
            int val = 50;
            int val1 = 100;
            callbyvalue c = new callbyvalue();
            Console.WriteLine("The value before call is" +val);
            c.change(val);
            Console.WriteLine("The value after called is" + val);
            callbyreference r1 = new callbyreference();
            Console.WriteLine("The value before call is" + val1);
            r1.change2(ref val1);
            Console.WriteLine("The value after call is" + val1);

        }
    }
}