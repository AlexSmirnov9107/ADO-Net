using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
   public  class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }
        public int Course { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public Group()
        {
            Students = new List<Student>();
        }
    }
}
