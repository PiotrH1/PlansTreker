using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using PlanTracker.Models;
using PlanTracker.DataAccess;

namespace ContosoUniversity.DAL
{
    public class SchoolInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<DirectionContext>
    {
        protected override void Seed(DirectionContext context)
        {
           
        }
    }
}