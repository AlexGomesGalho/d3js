using System;
using System.Collections.Generic;
using System.Text;
// this Code is for using System.Collections.Generic; 
namespace CollectionExamples
{
    public class StackExample
    {
       public Stack<string> Fnames = new Stack<string>();
    }
    public class QueueExample
    {
        public Queue<string> Lnames = new Queue<string>();
    }
   public class DictionaryExample 
    {
        public Dictionary<String, String> Employee = new Dictionary<string, string>();
    }

    public class SortedListExample
    {
        public SortedList<int, string> students  = new SortedList<int, string>();
    }
}
