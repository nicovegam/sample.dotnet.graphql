using System;
using System.Collections.Generic;
using System.Text;

namespace Aladelta.Promos.Users.Core.Models
{
    public class Provider
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Address Address { get; set; }
        public float Latitude { get; set; }
        public float Longitude { get; set; }
    }

    public class Address
    {
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Neighborhood { get; set; }
        public string City { get; set; }
        public string StateOrProvince { get; set; }
        public string Country { get; set; }
    }
}
