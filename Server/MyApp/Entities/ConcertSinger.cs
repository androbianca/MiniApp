using System;

namespace Entities
{
    public class ConcertSinger: BaseEntity
    {

        public Guid SingerId { get; set; }
        public Guid ConcertId { get; set; }
        public Singer Singer { get; set; }
        public Concert Concert { get; set; }

    }
}
