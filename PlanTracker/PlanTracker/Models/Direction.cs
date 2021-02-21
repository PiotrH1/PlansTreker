using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlanTracker.Models
{
    public class Direction
    {
        public int ID { get; set; }
        public string DirectionName { get; set; }
        public string DirectionDescription { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual ICollection<Todo> Todos { get; set; }
    }
}
