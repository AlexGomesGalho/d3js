using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    class Rectangle
    {
        private int length, breath;
        public void getdata2()
        {
            Console.WriteLine("Enter the Length:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the breath:");
            int breath = Convert.ToInt32(Console.ReadLine());
        }
        public double getArea()
        {
            return length * breath;
        }
        public void Display()
        {
            Console.WriteLine("Length: {0}", length);
            Console.WriteLine("Width: {0}", breath);
            Console.WriteLine("Area: {0}", getArea());
        }
    }
}
