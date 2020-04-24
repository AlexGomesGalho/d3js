using System;

namespace Inheritance
{
    //single level inheritance
    public class A
    {
        public int i = 50;
    }
    public class B:A
    {
        int j = 52;
        public void mult()
        {
            Console.WriteLine("Result" + i * j);
        }
    }

    class Salary
    {
        public float salary = 500000;
    }
    class Bonus : Salary
    {
        public float bonus = 60000;
    }

    //multi level inheritance
    class Animal
    {
        public void The()
        {
            Console.WriteLine("The");
        }
      
    }
     class Dog:Animal
     {
        public void DogIS()
        {
            Console.WriteLine("black dog is");
        }
     }
    class blackdog : Dog
    {
        public void eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class InhertanceExample
    {
        public static void Main(String[] args)
        {
            B b1 = new B();
            b1.mult();
            Bonus d = new Bonus();
            Console.WriteLine("Salary=" + d.salary);
            Console.WriteLine("Bonus=" + d.bonus);

            blackdog dg = new blackdog();
            dg.The();
            dg.DogIS();
            dg.eat();
        }
    }
    
   



}
