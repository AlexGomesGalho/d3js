using System;

namespace ArraytoFunction
{
    class Program
    {
        public void minval(int[] arr)
        {
            int min = arr[0];
            for(int i=0;i<arr.Length;i++)
            {
                if(min>arr[i])
                {
                    min = arr[i];
                   
                }
            }
            Console.WriteLine("The minimum value is" + min);
        }
        static void Main(string[] args)
        {
            int[] arr1 = { 10, 50, 20, 30, 60 };
            int[] arr2 = { 105, 106, 109, 50, 56 };
            Program m = new Program();
            m.minval(arr1);
            m.minval(arr2);
        }
    }
}
