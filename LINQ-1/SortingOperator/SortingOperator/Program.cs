using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingOperators
{
    class OrderbyExample
    {
        static void Main(string[] args)
        {
            List<student> objStud = new List<student>()
            {
                new student() {Name= "Aditya", ID= "101" ,BSubject = new List<string> {"math","science"} },
                new student() {Name= "Daksh", ID= "102" ,BSubject = new List<string> {"Geo","maths"} },
                new student() {Name= "Raj", ID= "103" ,BSubject = new List<string> {"math","science"} },
                new student() {Name= "Chetan", ID= "104" ,BSubject = new List<string> {"bio","science"} },
                new student() {Name= "Yaseer", ID= "105" ,BSubject = new List<string> {"math","phy"} }
            };

            var studentname = objStud.OrderBy(x => x.Name);
            foreach(var i in studentname)
            {
                Console.WriteLine(i.Name + " " +i.ID + " "+ i.BSubject.Count);
                
            }
            Console.ReadLine();


        }
            class student
        {
            public string Name {get;set;}
            public string ID { get; set; }
            public List<string> BSubject { get; set; }
        }
    }
}
