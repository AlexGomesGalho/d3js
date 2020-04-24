using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpPart12
{
    public delegate void traiDelegate(double Base, double Height);
    class Traingle
    {
        public void TraiArea(double Base, double Height)
        {
            Console.WriteLine("Area of a traingle:"+0.5*(Base*Height));
        }
       
    }
}
