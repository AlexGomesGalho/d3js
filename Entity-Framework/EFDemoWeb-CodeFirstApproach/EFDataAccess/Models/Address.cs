using System;
using System.Collections.Generic;
using System.Text;

namespace EFDataAccess.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string streetaddress { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string Zipcode { get; set; }

    }
}
