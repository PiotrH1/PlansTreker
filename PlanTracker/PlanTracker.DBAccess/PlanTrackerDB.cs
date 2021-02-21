using PlanTracker.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlanTracker.DBAccess
{
    public class PlanTrackerDB : DbContext
    {
        public PlanTrackerDB() : base("name=DefaultConnection")
        {

        }
        public DbSet<Direction> Directions { get; set; }
        public DbSet<Todo> Todos { get; set; }
       
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Direction>().Property(p => p.DirectionName).HasMaxLength(100);           
            modelBuilder.Entity<Todo>().Property(p => p.TodoName).HasMaxLength(100);
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Entity<Direction>().Property(p => p.DirectionDescription).HasColumnType("nvarchar(max)");
            modelBuilder.Entity<Todo>().Property(p => p.TodoDescription).HasColumnType("nvarchar(max)");
            base.OnModelCreating(modelBuilder);
        }
    }
}
