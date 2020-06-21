using System.Collections.Generic;

namespace Entities
{
    public class Singer : BaseEntity
    {
        public string Name { get; set; }

        public string MusicType { get; set; }
  
        public ICollection<ConcertSinger> Concerts { get; set; }

    }
}
