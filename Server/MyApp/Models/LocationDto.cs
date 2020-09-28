using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class LocationDto
    {
        public Guid Id { get; set; }
        public string Country { get; set; }
        public string County { get; set; }
        public string Name { get; set; }
        public string Street { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
    }
}
