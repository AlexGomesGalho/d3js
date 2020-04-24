using System;
using System.Collections.Generic;
using System.Linq;
namespace QuerySyntax_and_MethodSyntax
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Main(string[] args)
        {
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var querysyantx = from obj in list
                              where obj > 2
                              select obj;
            foreach (var i in querysyantx)
            {
                log.Debug(i);
            }
            log.Info("---------------------------");
            var methodsyntax = list.Where(obj => obj > 2);
            foreach (var i in methodsyntax)
            {
                log.Debug(i);
            }
            log.Info("---------------------------");

            int mixedsyntax = (from obj in list
                               select obj).Max();
                log.Debug("MAx Value is: "+mixedsyntax);
            

            Console.ReadKey();
        }
    }
}
