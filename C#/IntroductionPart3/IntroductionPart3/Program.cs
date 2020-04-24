using System;

namespace InstanceMethod
{
    class Validate
    {
        public static void Main(string[] args)
        {
            Validate q = new Validate();
            q.evenNumber();
        }
        public void evenNumber()
        {
            Console.WriteLine("Enter the even number you want to check!!");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even");

            }
            else
            {
                Console.WriteLine("Odd");
            }

        }

    }
}
