using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMv.Models
{
    public class SalesWebMvContext : DbContext
    {
        public SalesWebMvContext (DbContextOptions<SalesWebMvContext> options)
            : base(options)
        {
        }

        public DbSet<SalesWebMv.Models.Department> Department { get; set; }
    }
}
