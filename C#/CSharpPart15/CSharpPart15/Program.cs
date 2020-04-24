using System;
using System.Collections.Generic;
using CollectionExamples;
using System.Collections.Concurrent;
namespace Collections
{
    public class CollectionExample
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        public static void Main(string[] args)
        {
            var numbers = new List<int>() { 1, 5, 6, 5, 8, 4, 1, 5 }; //ListExample
            var names = new HashSet<string>() { "Aditya", "Aditya", "Sharma" }; //demonstation of hashset where it does not accepts duplicate values
            var decivalue = new SortedSet<double>() { 1.2, 5.6, 6.3, 0.3, 5, 8, 4.2, 1, 5 }; //sortedset Example
      

            foreach (var a in decivalue)
            {
                log.Debug(a);
            }
            Console.WriteLine("\n");
            foreach (var n in numbers)
            {
                log.Debug(n);
            }
            Console.WriteLine("\n");
            foreach (var name in names)
            {
                log.Debug(name);
            }

            log.Debug("\n");

            StackExample s = new StackExample();
            s.Fnames.Push("Aditya");
            s.Fnames.Push("Narayan");
            s.Fnames.Push("Sharma");
            foreach (var Fname in s.Fnames)
            {
                log.Debug(Fname);
            }
            log.Debug("Peek Element is:" + s.Fnames.Peek());
            log.Debug("Poping the peek Element:" + s.Fnames.Pop());
            log.Debug("Peek Element is:" + s.Fnames.Peek());

            log.Debug("\n");
            QueueExample q = new QueueExample();
            q.Lnames.Enqueue("Sharma");
            q.Lnames.Enqueue("Reddy");
            q.Lnames.Enqueue("Naidu");
            foreach (var Lname in q.Lnames)
            {
                log.Debug(Lname);
            }
            log.Debug("Peek Element is:" + q.Lnames.Peek());
            log.Debug("Poping the peek Element:" + q.Lnames.Dequeue());
            log.Debug("Peek Element is:" + q.Lnames.Peek());

            log.Debug("\n");

            var nodes = new LinkedList<string>(); //Creating a linked list of string
            nodes.AddLast("Taj Mahal");
            nodes.AddLast("Qutur Minar");
            nodes.AddLast("Ganga River");
            nodes.AddFirst("Golden Temple");

            foreach (var a in nodes)
            {
                log.Debug(a); //Demonstrating the AddFirst and AddLast methods
            }
            log.Debug("\n");
            //I want to insert new element between Ganga River
            LinkedListNode<string> node = nodes.Find("Ganga River");
            nodes.AddBefore(node, "Laxman Jula");
            nodes.AddAfter(node, "Ram Jula");

            foreach (var c in nodes)
            {
                log.Debug(c);
            }
            //DictionaryExample
            DictionaryExample dic = new DictionaryExample();
            dic.Employee.Add("101", "Sonoo");
            dic.Employee.Add("202", "Peter");
            dic.Employee.Add("303", "James");
            dic.Employee.Add("404", "Ratan");
            dic.Employee.Add("505", "Irfan");

            log.Debug("\n");
            foreach (KeyValuePair<string, string> kv in dic.Employee)
            {
                Console.WriteLine("Key:" + kv.Key + "Vlaue:" + kv.Value);
            }
            //SortedList Example
            SortedListExample Sl = new SortedListExample();
            Sl.students.Add(5, "Aditya");
            Sl.students.Add(6, "Daksh");
            Sl.students.Add(7, "Aditya M");
            Sl.students.Add(3, "Chetan");
            Sl.students.Add(10, "Ajay");

            Console.WriteLine("\n");
            foreach (KeyValuePair<int, string> sll in Sl.students)
            {
                log.Debug(sll.Key + " " + sll.Value);
            }
            Console.ReadLine();

        }
    }
}