using System;
using System.Collections.Generic;
using System.Text;

namespace CshapePart6
{
    class callbyreference
    {
        public void change2(ref int val1)
        {
            val1 *= val1;
            Console.WriteLine("The value when called is" + val1);

        }
    }
}
