using System;
using StaticContructor;
using Destructor;
using FunOverloading;
using Encapsulation;
using Inheritance;
using InterfaceExample;
using Runtimepolymorphism;
namespace oops
{
    class customer
    {
        // Member Variables    
        public string Name;

        //constuctor for initializing fields    
        public customer(string fname, string lname)
        {
            Name = fname + " " + lname;
        }
        
        public void AppendData()
        {
            Console.WriteLine(Name);
        }

           

        public static void Main(string[] args)
        {   
            customer obj = new customer("Barack", "Obama");
            obj.AppendData();

            Customer2.getdata();


            Customer3 obj1 = new Customer3();
            obj1.getData();

            Name obj2 = new Name();
            obj2.setName("Sharma");
            obj2.setName("Aditya", "Sharma");
            obj2.setName("Aditya", "N", "Sharma");


            Rectangle obj3 = new Rectangle();
            obj3.getdata2();
            obj3.Display();

            Father fObj = new Father();
            fObj.FatherMethod();

            //Here Child object can access both class methods    
            Child cObj = new Child();
            cObj.FatherMethod();
            cObj.ChildMethod();


            IStudent obj5 = new StudentDetails();
            obj5.print();
            //IStudent a = new IStudent();
            StudentDetails std = new StudentDetails();
            std.print();
            std.marks();
            Console.ReadKey();

            DClass d = new DClass();
            d.GetInfo();
            BClass b = new BClass();
            b.GetInfo();
       



        }
    }
}