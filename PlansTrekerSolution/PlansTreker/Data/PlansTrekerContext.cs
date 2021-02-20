using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PlansTreker.Models;

namespace PlansTreker.Data
{
    public class PlansTrekerContext : DbContext
    {
        public PlansTrekerContext (DbContextOptions<PlansTrekerContext> options)
            : base(options)
        {
        }

        public DbSet<PlansTreker.Models.Destination> Destination { get; set; }
    }
}
