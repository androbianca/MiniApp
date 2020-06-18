using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Singer : BaseEntity
    {
        public string Name { get; set; }

        public int Years { get; set; }
        public Guid ConcertId { get; set; }

        public Concert Concert { get; set; }
    }
}
