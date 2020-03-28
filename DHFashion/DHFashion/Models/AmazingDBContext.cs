using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DHFashion.Models
{
    public class AmazingDBContext: DbContext
    {
        public AmazingDBContext(DbContextOptions<AmazingDBContext> options):base(options)
        {
        }
        public DbSet<Items> Items { get; set; }
    }
}
