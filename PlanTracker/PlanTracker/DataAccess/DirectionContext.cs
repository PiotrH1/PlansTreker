using PlanTracker.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace PlanTracker.DataAccess
{
    public class DirectionContext : DbContext
    {

        public DirectionContext() : base("DirectionContext")
        {
        }

        public DbSet<Direction> Directions { get; set; }
        public DbSet<Todo> Todos { get; set; }        

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
