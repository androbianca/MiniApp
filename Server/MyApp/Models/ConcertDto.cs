using System;

namespace Models
{
    public class ConcertDto
    {
        public Guid Id { get; set; }
        public long Price { get; set; }
        public Guid LocationId { get; set; }
    }
}
