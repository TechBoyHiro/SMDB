using SMDB.Attributes;
using SMDB.Entities.Common;
using SMDB.InfraStructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SMDB.Entities
{
    public class Customer : BaseUser 
    {
        [Password]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public LocationBase LastLocation { get; set; }
        public DateTime BrithDay { get; set; }
    }
}
