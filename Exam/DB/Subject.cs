using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class Subject
    {
        public int SubjectId { get; set; }
        public String Name { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
        public Subject()
        {
            Teachers = new List<Teacher>();
        }
    }
}
