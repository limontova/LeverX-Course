using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<University> Universities { get; set; }
        public DbSet<UniversityTeacher> UniversityTeachers { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<City> Cities { get; set; }

        public ApplicationContext()
        {
            Database.EnsureCreated();
        }        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=Universitydb;Trusted_Connection=True;");
        }
    }
}
