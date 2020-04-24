using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Communication
{
    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string Type { get; set; }
    }
}
