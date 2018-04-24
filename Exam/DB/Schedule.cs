
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.Entity;
namespace DB
{
    public class Schedule
    {
        public int ScheduleId { get; set; }
        public virtual Group Group { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Subject Subject { get; set; }
        public DateTime Datetime { get; set; }
    }
}