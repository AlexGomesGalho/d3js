using System;
using System.Collections.Generic;
using System.Text;

namespace MultiCastDelegate
{
   public delegate int DelMethod(int x, int y);
        public class TestdelegateMethod
        {
           public int method_1(int x, int y)
            {
                Console.WriteLine("You are in method_1 for add ");
                return (x + y);
            }
            public int method_2(int x, int y)
            {
                Console.WriteLine("You are in method_2 for subtract ");
                return (x - y);
            }

        }
}