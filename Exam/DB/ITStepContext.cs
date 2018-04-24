using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DB
{
   public class ITStepContext: DbContext
    {
        public ITStepContext() : base("ITStep")
        { }

        // Отражение таблиц базы данных на свойства с типом DbSet
        public DbSet<Schedule> Schedule { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }

    }
}
