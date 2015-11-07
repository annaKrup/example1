using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class UserContext : DbContext
    {
        public UserContext():base("DbConnection")
        { }
          
        public DbSet<User> Users { get; set; }
    }
    
}
