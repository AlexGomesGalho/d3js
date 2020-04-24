using System;
using System.Collections.Generic;
using System.Text;

namespace StaticContructor
{
    class Customer2
    {
        static private string CustName;
        static Customer2()
        {
          CustName = "ADITYA";
        }

        public static void getdata()
        {
            Console.WriteLine(CustName);
        }


    }
}
