using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace DB
{
    public class Teacher
    {
        public int TeacherId { get; set; }
        public String Name { get; set; }
        public int Experience { get; set; }
        public String Position { get; set; }

        public virtual ICollection<Group> Groups { get; set; }
        public virtual ICollection<Subject> Subjects { get; set; }
        public int? SubjectId { get; set; }
        public int? GroupId { get; set; }
        public Teacher()
        {
            Groups = new List<Group>();
            Subjects = new List<Subject>();
        }
    }
   
}
