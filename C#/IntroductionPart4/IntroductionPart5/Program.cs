using System;
using SecondExample;


namespace ErrorHandlingApplication
{
    class DivNumbers
    {
        int result;

        DivNumbers()
        {
            result = 0;
        }
        public void division(int num1, int num2)
        {
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Exception caught: {0}", e);
            }
             Console.WriteLine("Result is: {0}", result);
        }
        static void Main(string[] args)
        {
            DivNumbers d = new DivNumbers();
            d.division(25,0);
            Test test = new Test();
           
            int result = test.Grandparentmethod(10);
            Console.WriteLine("The value present is"+result);
            
            Console.ReadKey();
        }
    }
    
}