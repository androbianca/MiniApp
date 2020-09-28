using System.Collections.Generic;

namespace Entities
{
    public class Location : BaseEntity
    {
        public string Country {get;set;}
        public string County { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public ICollection<Concert> Concerts { get; set; }

    }
}
