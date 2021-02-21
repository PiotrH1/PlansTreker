using PlanTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PlanTracker.Web.Models
{
    public class DirectionViewModel
    {
        public Direction Direction { get; set; }
        public List<Todo> Todoes { get; set; }
    }
}