using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAwaitExample
{
    class Program
    {
        static void Main(string[] Args)
        {
            Console.WriteLine("Starting");
            var worker = new worker();
            worker.dowork();

            while (!worker.iscomplete)
            {
                Console.WriteLine(".");
                Thread.Sleep(2000);
            }
            Console.WriteLine("DONE!!");
            Console.ReadLine();
        }
    }
    public class worker
    {
        public bool iscomplete { get; set; }
            public async void dowork()
            {
            this.iscomplete = false;
            Console.WriteLine("Doing Work");
            await longprocess();
            Console.WriteLine("Work Completed!");
            iscomplete = true;
        }
        public Task longprocess()
        {
            return Task.Factory.StartNew(() => {
                Console.WriteLine("Working");
                Thread.Sleep(3000);
            });
           

        }
    }
}
