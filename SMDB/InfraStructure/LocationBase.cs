using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMDB.InfraStructure
{
    public class LocationBase
    {
        public string Full_Address { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string Description { get; set; }
    }
}
