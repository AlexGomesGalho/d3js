using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Father
    {
        public Father()
        {
            Console.WriteLine("HUM FATHER CONSTRUCTOR MEY HEY");
        }
        public void FatherMethod()
        {
            Console.WriteLine("this property belong to Father");
        }
    }

    //Derived class    
    public class Child : Father
    {
        public Child() : base()
        {
            Console.WriteLine("Tera baap idhar hey");
        }

        public void ChildMethod()
        {
            Console.WriteLine("this property belong to Child");
        }
    }
    
          
    
     
}
