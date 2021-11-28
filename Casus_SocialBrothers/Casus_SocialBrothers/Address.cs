using Nest;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Casus_SocialBrothers
{
    [Table("Adresses")]
    public class Address
    {
        
        public int ID { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string StreetName { get; set; }
        public string HouseNumber { get; set; }
        public string Country { get; set; }

    }
}
