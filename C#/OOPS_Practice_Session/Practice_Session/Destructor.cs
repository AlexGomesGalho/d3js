using System;
using System.Collections.Generic;
using System.Text;

namespace Destructor
{
    public class Customer3
    {
        public int x, y;
        public Customer3()
        {
            Console.WriteLine("Field is initialized!!");
            x = 10; 
        }
        public void getData()
        {
            y = x * x;
            Console.WriteLine(y);
        }

        public void Dispose()
        {
            Console.WriteLine("Field Cleaned!!");
            int x = 20;
            int y = 30;
        }

        ~Customer3()
            {
            Dispose();
        }
    }


}
