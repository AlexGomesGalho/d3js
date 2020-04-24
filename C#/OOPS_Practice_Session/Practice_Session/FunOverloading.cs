using System;
using System.Collections.Generic;
using System.Text;

namespace FunOverloading
{
    public class Name
    {
      
        public void setName(string last)
        {
            string Name = last;
            Console.WriteLine(Name);
        }
        public void setName(string First, string last)
        {
            string Name = First + " "+last;
            Console.WriteLine(Name);
        }
        public void setName(string First, string middle , string last)
        {
            string Name = First+" " +middle+" "+last;
            Console.WriteLine(Name);
        }

    }
}
