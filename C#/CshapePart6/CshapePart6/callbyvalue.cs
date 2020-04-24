using System;
using System.Collections.Generic;
using System.Text;

namespace CshapePart6
{
    class callbyvalue
    {
        public void change(int val)
        {
            val *= val;
            Console.WriteLine("The value when called is" + val);

        }
    }
}