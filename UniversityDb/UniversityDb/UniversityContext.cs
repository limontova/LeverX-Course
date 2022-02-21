using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDb.Model;

namespace UniversityDb
{
    public class UniversityContext : DbContext
    {
        public DbSet<City> Cities { get; set; }
        public DbSet<University> Universities { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<UniversityTeacher> UniversityTeachers { get; set; }
        public DbSet<StudentSubject> StudentSubjects { get; set; }
        public UniversityContext()
        {
            //Database.EnsureDeleted();   // удаляем бд со старой схемой
           // Database.EnsureCreated();   // создаем бд с новой схемой
        }
        //public UniversityContext(DbContextOptions<UniversityContext> options) : base(options)
        //{
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TD0O345\\SQLEXPRESS;Database=UniversityDb;Trusted_Connection=True;");
            }
        }
    }
}
