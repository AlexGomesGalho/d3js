using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQExample
{
    class Operations
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {

            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            //var QuerySyntax = from obj in integerList
            //where obj > 5
           // select obj;
           

            var MethodSyntax = integerList.Where(obj => obj > 5).ToArray(); 

            foreach(var item in MethodSyntax)
            {
                log.Debug(item + " ");
            }
            Console.ReadKey();

        }
    }
}
