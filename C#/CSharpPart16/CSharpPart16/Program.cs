using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Concurrent;

namespace ConcurrentExamples
{
    class Program
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        static void Main(string[] args)
        {
            int[] arr5 = { 101,202,303,404,505,606,707};

            ConcurrentBag<int> bag = new ConcurrentBag<int>();
            foreach (var items in arr5)
            {
                bag.Add(items);
                log.Debug("Adding multiple items in the bag"+items);
            }

            log.Info("Removing items from the bag using TryPeek method:");
            int itemss;
            bag.TryPeek(out itemss);
            log.Debug("The element peeked out is:"+itemss);
            bag.TryPeek(out itemss);
            log.Debug("The element peeked out is:" + itemss);
            bag.TryPeek(out itemss);
            log.Debug("The element peeked out is:" + itemss);

            log.Info("Removing items from the bag using TryTake method:");
            int itemsss;
            bag.TryTake(out itemsss);
            log.Debug("The element Taken out is:" + itemsss);
            bag.TryTake(out itemsss);
            log.Debug("The element taken out is:" + itemsss);
            bag.TryTake(out itemsss);
            log.Debug("The element taken out is:" + itemsss);

            foreach (var ele in bag)
            {
                log.Debug(ele);
            }


            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
      
            foreach (var l in stack)
            {
                log.Debug("The Stack ELements are:"+l);
            }

          
            int[] ints = { 5, 6, 8 };
            stack.PushRange(ints);
            foreach (var k in stack)
            {
                log.Debug("This is an example of pushing multiple elements into the stack:"+k);
            }

            int count = stack.Count();
            log.Info("Total number of element in the stack is:"+count);

            int item;
            stack.TryPeek(out item);      //Using Try peek method
            log.Debug("Removeing element from thr stack USing TryPeek:"+item); //Print 8

            // Difference between TryPeek and TryDequeue methods
            // Both method works same, TryDequeue method removes an item from the list and TryPeek does not remove an item from the list.


            int item2;
            bool isSuccess2 = stack.TryPop(out item2); //isSuccess = True, item = 6     //USing TryPop method
            stack.TryPop(out item2);
            log.Debug("Removeing element from thr stack using tryPop:"+item2);

            int[] array = stack.ToArray();
            foreach (var j in array)
            {
                log.Debug("Converting stack to array:"+j);
            }
            

            ConcurrentQueue<int> coll = new ConcurrentQueue<int>();
            coll.Enqueue(56);
            coll.Enqueue(57);
            coll.Enqueue(58);
            
            foreach(var i in coll)
            {
                log.Debug("Printing all the Queue values:"+i);
            }

            int item3;
            coll.TryDequeue(out item3);
            log.Debug("Removing element from the queue:"+item3);
            

            bool isEmpty = coll.IsEmpty;
           
            log.Debug("IS the queue Empty?:"+isEmpty);

            ConcurrentDictionary<string, string> dict = new ConcurrentDictionary<string, string>();
            dict.TryAdd("1", "Aditya"); 
            dict.TryAdd("2", "Sharma");  
            dict.TryAdd("2", "N"); //returns false;

            string itemValue1;
            dict.TryGetValue("1", out itemValue1);  //returns true
            log.Debug("Retreving the element using its key:"+itemValue1);

            foreach (var item4 in dict)
            {
                log.Debug("Retreving all the elements of the dic:"+item4.Key + "-" + item4.Value);
            }
            int total = dict.Count();
            log.Debug("Total elements in the dic are:"+total);

            bool firstItemFound = dict.ContainsKey("5");
            log.Debug(firstItemFound); //returns false

            Console.ReadKey();
        }
    }
   
}
