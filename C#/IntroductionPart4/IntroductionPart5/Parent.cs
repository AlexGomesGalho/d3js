using System;
using System.Collections.Generic;
using System.Text;

namespace SecondExample
{
    class Test
    {
        public int Grandparentmethod(int parent)
        {
            return parentmethod(parent);
        }

        public int parentmethod(int Position)
        {
            return GetNumber(Position);
        }
        public int GetNumber(int position)
        {
            int output = 0;
            int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            try
            {
                output = numbers[position];
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            return output;
        }
    }
}