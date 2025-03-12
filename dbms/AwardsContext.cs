using dbms.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbms
{
    public class AwardsContext : DbContext
    {
        public DbSet<Organization> Organizations { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Award> Awards { get; set; }
    }
}
