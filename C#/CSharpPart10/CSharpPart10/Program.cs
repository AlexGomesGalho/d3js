using System;
using System.Collections.Generic;
using CollectionExamples;
using System.Collections.Concurrent;
namespace Collections
{
    public class CollectionExample { 
    
        public static void Main(string[] args)
        {
         var numbers = new List<int>() { 1,5,6,5,8,4,1,5}; //ListExample
         var names = new HashSet<string>() { "Aditya", "Aditya", "Sharma" }; //demonstation of hashset where it does not accepts duplicate values
         var decivalue = new SortedSet<double>() { 1.2, 5.6, 6.3, 0.3, 5 , 8, 4.2, 1, 5 }; //sortedset Example
         BlockingCollection<int> bCollection = new BlockingCollection<int>(10);
            bCollection.Add(1);
            bCollection.Add(2);
            foreach (int item in bCollection.GetConsumingEnumerable())
            {
                Console.WriteLine(item);
            }

            foreach (var a in decivalue)
            {
                Console.WriteLine(a);
            }
            Console.WriteLine("\n");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("\n");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
           
            Console.WriteLine("\n");

            StackExample s = new StackExample();
            s.Fnames.Push("Aditya");
            s.Fnames.Push("Narayan");
            s.Fnames.Push("Sharma");
            foreach(var Fname in s.Fnames)
            {
                Console.WriteLine(Fname);
            }
            Console.WriteLine("Peek Element is:" + s.Fnames.Peek());
            Console.WriteLine("Poping the peek Element:" + s.Fnames.Pop());
            Console.WriteLine("Peek Element is:" + s.Fnames.Peek());
            
            Console.WriteLine("\n");
            QueueExample q = new QueueExample();
            q.Lnames.Enqueue("Sharma");
            q.Lnames.Enqueue("Reddy");
            q.Lnames.Enqueue("Naidu");
            foreach (var Lname in q.Lnames)
            {
                Console.WriteLine(Lname);
            }
            Console.WriteLine("Peek Element is:" + q.Lnames.Peek());
            Console.WriteLine("Poping the peek Element:" + q.Lnames.Dequeue());
            Console.WriteLine("Peek Element is:" + q.Lnames.Peek());

            Console.WriteLine("\n");

            var nodes = new LinkedList<string>(); //Creating a linked list of string
            nodes.AddLast("Taj Mahal");
            nodes.AddLast("Qutur Minar");
            nodes.AddLast("Ganga River");
            nodes.AddFirst("Golden Temple");

            foreach(var a in nodes)
            {
                Console.WriteLine(a); //Demonstrating the AddFirst and AddLast methods
            }
            Console.WriteLine("\n");
            //I want to insert new element between Ganga River
            LinkedListNode<string> node = nodes.Find("Ganga River");
            nodes.AddBefore(node,"Laxman Jula");
            nodes.AddAfter(node,"Ram Jula");

            foreach(var c in nodes)
            {
                Console.WriteLine(c);
            }
            //DictionaryExample
            DictionaryExample dic = new DictionaryExample();
            dic.Employee.Add("101", "Sonoo");
            dic.Employee.Add("202", "Peter");
            dic.Employee.Add("303", "James");
            dic.Employee.Add("404", "Ratan");
            dic.Employee.Add("505", "Irfan");
           
            Console.WriteLine("\n");
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
                Console.WriteLine(sll.Key + " " + sll.Value);
            }

        }
    }
}
