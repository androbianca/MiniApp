using System;
using System.Collections.Generic;

namespace Entities
{
    public class Concert: BaseEntity
    {
        public long Price { get; set; }
        public Guid LocationId { get; set; }
        public Location Location { get; set; }
        public ICollection<ConcertSinger> Singers { get; set; }

    }
}
