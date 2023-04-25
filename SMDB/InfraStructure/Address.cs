using SMDB.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMDB.InfraStructure
{
    public class Address
    {
        public string City { get; set; }
        public string Blvd { get; set; }
        public string Street { get; set; }
        [JustNumber]
        public string Plaque { get; set; }
        public string Complete_Address { get; set; }
    }
}
