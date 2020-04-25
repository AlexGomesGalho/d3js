using System;
using System.Collections.Generic;
using System.Text;
using CSharpPart12;
using MultiCastDelegate;


namespace DelegateExample2
{
    public delegate void RectDelegate(double Width, double Height);
   
    class Rectangle
    {
        public void GetArea(double Width, double Height)
        {
            Console.WriteLine("Area of rectangle:"+Width * Height);
        }

        public void GetPerimeter(double Width, double Height)
        {
            Console.WriteLine("Perimeter of rectangle:"+ 2 * (Width + Height));
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            RectDelegate obj = new RectDelegate(rect.GetArea);
            obj += rect.GetPerimeter;
            obj.Invoke(56.23, 23.45);
            Console.WriteLine("\n");
            //Break line 
			Console.WriteLine("Good Morning");
           
            Traingle trai = new Traingle();
            traiDelegate obj1 = new traiDelegate(trai.TraiArea);
            obj1.Invoke(56.36, 58.56);
            Console.WriteLine("\n");
            
          
            TestdelegateMethod p = new TestdelegateMethod();
            DelMethod del = new DelMethod(p.method_1);
            // Here we have multicast
            del += new DelMethod(p.method_2);
            Console.WriteLine(del(50, 10));
          
            // Here again we have multicast
            del -= new DelMethod(p.method_2);
            Console.WriteLine(del(20, 10));
            Console.ReadKey();

        }
    }
}
