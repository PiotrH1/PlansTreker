using System;

namespace PlanTracker.Models
{
    public class Todo
    {
        public Todo(){

        }
        public int TodoID { get; set; }
        public int DirectionID { get; set; }
        public string TodoName { get; set; }
        public string TodoDescription { get; set; }
        public DateTime CreatedtDate { get; set; }       
    }
}