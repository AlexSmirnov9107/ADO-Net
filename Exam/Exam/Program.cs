using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new ITStepContext())
            {
                Group g = new Group { Name = "SMP-171", Course = 1 };
                db.Groups.Add(g);
                db.SaveChanges();

                db.Students.Add(new Student { Group = g, Name = "AlexSm", Course = 1 });
                db.SaveChanges();


                Teacher t = new Teacher { Name="Oleg",Experience=1};
                t.Groups.Add(g);
                db.Teachers.Add(t);
                db.SaveChanges();

                Subject s = new Subject { Name = "ADO-Net"};
                s.Teachers.Add(t);
                db.Subjects.Add(s);

                var ts = db.Teachers.ToList();
                foreach (var teach in ts) { 
                    Console.WriteLine("{0}", teach.Name );
                }
                db.Schedule.Add(new Schedule { Group = g, Teacher = t, Datetime = DateTime.Now,Subject=s });
                db.SaveChanges();

            }
            Console.WriteLine("done");
            Console.ReadKey();
        }
    }
}
