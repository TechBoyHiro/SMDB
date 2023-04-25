using Microsoft.AspNetCore.Identity;
using SMDB.InfraStructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMDB.Entities.Common
{
    public class BaseUser : IdentityUser
    {
        public Address address { get; set; }
    }
}
