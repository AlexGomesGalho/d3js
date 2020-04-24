using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IStudent

    {
        void print();
    }
    interface Imarks
    {
        void marks();
    }
    class StudentDetails : IStudent, Imarks
    {

        public void print()
        {
            Console.WriteLine("Student 1");
        }
        public void marks()
        {
            Console.WriteLine(100);
        }
    }
   
    
     
}
