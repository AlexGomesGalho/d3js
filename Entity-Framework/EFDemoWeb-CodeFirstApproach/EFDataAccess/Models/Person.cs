using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
   public class Person
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Address> Address = new List<Address>();

        public List<Email> EmailAddess = new List<Email>();


    }
}
