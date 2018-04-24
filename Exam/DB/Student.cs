using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Student
    {
        public int StudentId { get; set; }
        public String Name { get; set; }
        public int Course { get; set; }
        public virtual Group Group { get; set; }
        public int? GroupId { get; set; }
    }
}
