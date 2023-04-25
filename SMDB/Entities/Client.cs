using SMDB.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMDB.Entities
{
    public class Client : BaseUser
    {
        public DbSet<Entity> Entities { get; set; } 
    }
}
