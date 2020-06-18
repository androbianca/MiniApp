using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Location : BaseEntity
    {
        public string Country {get;set;}
        public string County { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public Concert Concert { get; set; }

    }
}
