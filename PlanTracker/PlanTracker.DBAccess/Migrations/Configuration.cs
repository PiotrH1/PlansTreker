namespace PlanTracker.DBAccess.Migrations
{
    using PlanTracker.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PlanTracker.DBAccess.PlanTrackerDB>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(PlanTracker.DBAccess.PlanTrackerDB context)
        {
            var directions = new List<Direction>
            {
            new Direction{DirectionName="Philly",DirectionDescription="Alexander",CreatedDate=DateTime.Parse("2005-09-01")},
            new Direction{DirectionName="NewYork",DirectionDescription="Alonso",CreatedDate=DateTime.Parse("2002-09-01")},
            new Direction{DirectionName="Boston",DirectionDescription="Anand",CreatedDate=DateTime.Parse("2003-09-01")}
            };

            directions.ForEach(s => context.Directions.Add(s));
            context.SaveChanges();

            var todos = new List<Todo>
            {
            new Todo{DirectionID=1,TodoName="Fun",TodoDescription = "leave it empty for now"},
            new Todo{DirectionID=1,TodoName="Fun",TodoDescription = "leave it empty for now"},
            new Todo{DirectionID=1,TodoName="Fun",TodoDescription = "leave it empty for now"}
            };
            todos.ForEach(s => context.Todos.Add(s));
            context.SaveChanges();
        }
    }
}
