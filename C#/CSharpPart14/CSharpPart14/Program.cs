using System;
using System.Threading;
namespace ThreadTest
{
    class Threadtest
    {
        static void test1()
        {
            for(int i=0;i<50;i++)
            {
                Console.WriteLine("Test1:" + i);
                
            }
            Console.WriteLine("thread 1 exiting");
        }
        static void test2()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test2:" + i);
                if (i == 50)
                {
                    Console.WriteLine("Test 2 is going to sleep");
                    Thread.Sleep(15000);
                    Console.WriteLine("Thread 2 woke up!");
                }
               
            }
            Console.WriteLine("thread 2 exiting");
        }
        static void test3()
        {
            for (int i = 0; i < 50; i++)
            {
                Console.WriteLine("Test3:" + i);
            }
            Console.WriteLine("thread 3 exiting");
        }
        static void Main(string[] args)
        {
            Thread t1 = new Thread(test1);
            Thread t2 = new Thread(test2);
            Thread t3 = new Thread(test3);

            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main thread exiting");
        }
    }
}
