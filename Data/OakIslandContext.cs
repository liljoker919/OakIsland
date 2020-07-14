using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OakIsland.Models;

namespace OakIsland.Data
{
    public class OakIslandContext : DbContext
    {
        public OakIslandContext (DbContextOptions<OakIslandContext> options)
            : base(options)
        {
        }

        public DbSet<OakIsland.Models.Business> Business { get; set; }
    }
}
