using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input Parameter = > (Expression)
            Func<int, int> Result = x => x * x;
            Console.WriteLine(Result(10));
            Console.ReadLine();
        }
    }
}
