using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDb.Model;

namespace UniversityDb
{
    internal class UniversityContext
    {
        public DbSet<University> Universities { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<UniversityTeacher> UniversityTeachers { get; set; }
    }
}
