using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace School.Models
{
    public class AppDpContext : DbContext
    {
        public AppDpContext(DbContextOptions<AppDpContext> options)
            :base (options)
        {
        }

        public DbSet<Database.Schools> tbSchools { get; set; }
        public DbSet<Database.Students> tbStudents { get; set; }
        public DbSet<Database.Days> tbDays { get; set; }
        public DbSet<Database.SchoolClass> tbSchoolClass { get; set; }
        public DbSet<Database.Subjects> tbSubjects { get; set; }
        public DbSet<Database.SubjectTable> tbSubjectTable { get; set; }
        public DbSet<Database.Teachers> tbTeachers { get; set; }
        public DbSet<Database.TeachersAndSubject> tbTeachersAndSubject { get; set; }

        protected override void OnModelCreating( ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<School.Models.Database.Days>().HasData(
                new Models.Database.Days {DayID=1,DayName= "Saturday" },
                  new Models.Database.Days { DayID = 2, DayName = "Sunday" },
                     new Models.Database.Days { DayID = 3, DayName = "Monday" },
                          new Models.Database.Days { DayID = 4, DayName = "Tuesday" },
                               new Models.Database.Days { DayID = 5, DayName = "Wednesday" },
                                  new Models.Database.Days { DayID = 6, DayName = "Thursday" },
                                     new Models.Database.Days { DayID = 7, DayName = "Friday" }
                );

            modelBuilder.Entity<Models.Database.Schools>().HasData(
                new Models.Database.Schools {SchoolID=1,SchoolName="School1" },
                 new Models.Database.Schools { SchoolID = 2, SchoolName = "School2" },
                   new Models.Database.Schools { SchoolID = 3, SchoolName = "School3" },
                     new Models.Database.Schools { SchoolID = 4, SchoolName = "School4" }
                );

            modelBuilder.Entity<Models.Database.SchoolClass>().HasData(
                new Models.Database.SchoolClass {SchoolClassID=1,ClassName="Class 1",SchoolID=1 },
                       new Models.Database.SchoolClass { SchoolClassID = 2, ClassName = "Class 2", SchoolID = 1 },
                               new Models.Database.SchoolClass { SchoolClassID = 3, ClassName = "Class 3", SchoolID = 1 },
                                       new Models.Database.SchoolClass { SchoolClassID = 4, ClassName = "Class 4", SchoolID = 1 },
                                               new Models.Database.SchoolClass { SchoolClassID = 5, ClassName = "Class 5", SchoolID = 1 }
                );


            modelBuilder.Entity<Models.Database.Subjects>().HasData(
                new Database.Subjects {SubjectsID=1,SubjectName="Sub 1" },
                   new Database.Subjects { SubjectsID = 2, SubjectName = "Sub 2" },
                        new Database.Subjects { SubjectsID = 3, SubjectName = "Sub 3" },
                             new Database.Subjects { SubjectsID = 4, SubjectName = "Sub 4" }
                );

            modelBuilder.Entity<Models.Database.Teachers>().HasData(
               new Database.Teachers { TeacherID = 1, TeacherName = "Teacher 1" },
                  new Database.Teachers { TeacherID = 2, TeacherName = "Teacher 2" },
                       new Database.Teachers { TeacherID = 3, TeacherName = "Teacher 3" },
                            new Database.Teachers { TeacherID = 4, TeacherName = "Teacher 4" }
               );



        }
    }
}
