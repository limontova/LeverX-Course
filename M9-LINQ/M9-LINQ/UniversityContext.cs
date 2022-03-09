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
        public DbSet<City> City { get; set; }
        public DbSet<University> University { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Group> Group { get; set; }
        public DbSet<Subject> Subject { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<UniversityTeacher> UniversityTeacher { get; set; }
        public DbSet<StudentSubject> StudentSubject { get; set; }
        public UniversityContext()
        {
            //Database.EnsureDeleted();   // удаляем бд со старой схемой
           // Database.EnsureCreated();   // создаем бд с новой схемой
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-TD0O345\\SQLEXPRESS;Database=UniversityDb;Trusted_Connection=True;");
            }
            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().HasData(
                new Student[]
                {
                    new Student
                    {
                        StudentID = 1,
                        Name = "Dasha",
                        Birthday =  new DateTime(2000, 3, 23),
                        Bonus = 20,
                        Bursary = 1000,
                        GroupID = 1,
                        CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 2,
                        Name = "Masha",
                        Birthday =  new DateTime(2000, 1, 2),
                        Bonus = 30,
                        Bursary = 120,
                        GroupID = 1,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 3,
                        Name = "Misha",
                        Birthday =  new DateTime(2000, 7, 20),
                        Bonus = 20,
                        Bursary = 1200,
                        GroupID = 1,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 4,
                        Name = "Oksana",
                        Birthday =  new DateTime(2001, 1, 20),
                        Bonus = 15,
                        Bursary = 500,
                        GroupID = 2,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 5,
                        Name = "Sasha",
                        Birthday =  new DateTime(2000, 11, 12),
                        Bonus = 20,
                        Bursary = 1000,
                        GroupID = 3,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 6,
                        Name = "Dasha",
                        Birthday =  new DateTime(1999, 11, 8),
                        Bonus = 30,
                        Bursary = 120,
                        GroupID = 3,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 7,
                        Name = "Misha",
                        Birthday =  new DateTime(1998, 7, 6),
                        Bonus = 20,
                        Bursary = 1200,
                        GroupID = 6,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 8,
                        Name = "Olga",
                        Birthday =  new DateTime(1999, 5, 5),
                        Bonus = 15,
                        Bursary = 500,
                        GroupID = 6,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 9,
                        Name = "Sasha",
                        Birthday =  new DateTime(2000, 11, 22),
                        Bonus = 20,
                        Bursary = 1000,
                        GroupID = 2,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 10,
                        Name = "Masha",
                        Birthday =  new DateTime(2000, 1, 2),
                        Bonus = 30,
                        Bursary = 120,
                        GroupID = 6,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 11,
                        Name = "Lesha",
                        Birthday =  new DateTime(2000, 7, 20),
                        Bonus = 20,
                        Bursary = 1200,
                        GroupID = 4,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 12,
                        Name = "Ulyana",
                        Birthday =  new DateTime(2001, 4, 3),
                        Bonus = 15,
                        Bursary = 500,
                        GroupID = 4,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 13,
                        Name = "Sergey",
                        Birthday =  new DateTime(2000, 3, 4),
                        Bonus = 20,
                        Bursary = 1000,
                        GroupID = 4,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 14,
                        Name = "Danya",
                        Birthday =  new DateTime(1999, 12, 12),
                        Bonus = 30,
                        Bursary = 120,
                        GroupID = 4,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 15,
                        Name = "Valya",
                        Birthday =  new DateTime(1998, 7, 6),
                        Bonus = 20,
                        Bursary = 1200,
                        GroupID = 5,
                         CityID = 1,
                    },
                    new Student
                    {
                        StudentID = 16,
                        Name = "Petr",
                        Birthday =  new DateTime(2002, 1, 1),
                        Bonus = 15,
                        Bursary = 500,
                        GroupID = 5,
                         CityID = 2,
                    }
                }
                );
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<City>().HasData(
                new City[]
                {
                    new City
                    {
                        CityID = 1,
                        Name = "Minsk",
                        Population = 123456
                    },
                     new City
                    {
                        CityID = 2,
                        Name = "Brest",
                        Population = 1234
                    },
                }
                );
            modelBuilder.Entity<University>().HasData(
                new University[]
                {
                    new University
                    {
                        UniversityID = 1,
                        Name = "BSUIR",
                        Address = "address1",
                        CityID = 1
                    },
                    new University
                    {
                        UniversityID = 2,
                        Name = "BSU",
                        Address = "address2",
                        CityID = 1
                    },
                    new University
                    {
                        UniversityID = 3,
                        Name = "BSUSTT",
                        Address = "address3",
                        CityID = 2
                    }
                }
                );
            modelBuilder.Entity<Group>().HasData(
                new Group[]
                {
                    new Group
                    {
                        GroupID = 1,
                        Name = "First",
                        UniversityID = 1
                    },
                     new Group
                    {
                        GroupID = 2,
                        Name = "Second",
                        UniversityID = 1
                    },
                      new Group
                    {
                        GroupID = 3,
                        Name = "Third",
                        UniversityID = 1
                    },
                       new Group
                    {
                        GroupID = 4,
                        Name = "First",
                        UniversityID = 2
                    },
                     new Group
                    {
                        GroupID = 5,
                        Name = "Second",
                        UniversityID = 2
                    },
                      new Group
                    {
                        GroupID = 6,
                        Name = "Third",
                        UniversityID = 3
                    }
                }
                );
            
            modelBuilder.Entity<Subject>().HasData(
                new Subject[]
                {
                    new Subject
                    {
                    SubjectID = 1,
                    Name = "Math",
                    Duration = 60,
                    },
                    new Subject
                    {
                    SubjectID = 2,
                    Name = "Russian",
                    Duration = 80,
                    },
                    new Subject
                    {
                    SubjectID = 3,
                    Name = "Belarusian",
                    Duration = 60,
                    },
                    new Subject
                    {
                    SubjectID = 4,
                    Name = "English",
                    Duration = 80,
                    },
                }
                );
            //modelBuilder.Entity<StudentSubject>(s =>
            //{
            //    s.Property(b => b.StudentSubjectId).ValueGeneratedOnAdd();
            //});
            //modelBuilder.Entity<StudentSubject>().HasKey(u=>u.Id);
            modelBuilder.Entity<StudentSubject>().HasKey(p=>new {p.StudentID, p.SubjectID});
            modelBuilder.Entity<StudentSubject>().HasData(
            new StudentSubject[]
            {
                    new StudentSubject
                    {
                        //Id = 1,
                        StudentID = 1,
                        SubjectID = 1,
                        Mark = 8,
                    },
                    // new StudentSubject
                    //{
                    //   // Id = 2,
                    //    StudentID = 1,
                    //    SubjectID = 2,
                    //    Mark = 9,
                    //},
                    //   new StudentSubject
                    //{
                    //    //Id = 3,
                    //    StudentID = 1,
                    //    SubjectID = 3,
                    //    Mark = 10,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 4,
                    //    StudentID = 1,
                    //    SubjectID = 4,
                    //    Mark = 7,
                    //},
                    // new StudentSubject
                    //{
                    //   // Id = 5,
                    //    StudentID = 2,
                    //    SubjectID = 1,
                    //    Mark = 5,
                    //},
                    // new StudentSubject
                    //{
                    //   // Id = 6,
                    //    StudentID = 2,
                    //    SubjectID = 2,
                    //    Mark = 9,
                    //},
                    //   new StudentSubject
                    //{
                    //    //Id = 7,
                    //    StudentID = 2,
                    //    SubjectID = 3,
                    //    Mark = 10,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 8,
                    //    StudentID = 2,
                    //    SubjectID = 4,
                    //    Mark = 6,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 9,
                    //    StudentID = 3,
                    //    SubjectID = 1,
                    //    Mark = 7,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 10,
                    //    StudentID = 3,
                    //    SubjectID = 2,
                    //    Mark = 7,
                    //},
                    //   new StudentSubject
                    //{
                    //    //Id = 11,
                    //    StudentID = 3,
                    //    SubjectID = 3,
                    //    Mark = 7,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 12,
                    //    StudentID = 3,
                    //    SubjectID = 4,
                    //    Mark = 10,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 13,
                    //    StudentID = 4,
                    //    SubjectID = 1,
                    //    Mark = 10,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 14,
                    //    StudentID = 4,
                    //    SubjectID = 2,
                    //    Mark = 7,
                    //},
                    //   new StudentSubject
                    //{
                    //    //Id = 15,
                    //    StudentID = 4,
                    //    SubjectID = 3,
                    //    Mark = 10,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 16,
                    //    StudentID = 4,
                    //    SubjectID = 4,
                    //    Mark = 10,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 17,
                    //    StudentID = 5,
                    //    SubjectID = 1,
                    //    Mark = 8,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 18,
                    //    StudentID = 5,
                    //    SubjectID = 2,
                    //    Mark = 8,
                    //},
                    //   new StudentSubject
                    //{
                    //    //Id = 19,
                    //    StudentID = 5,
                    //    SubjectID = 3,
                    //    Mark = 8,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 20,
                    //    StudentID = 5,
                    //    SubjectID = 4,
                    //    Mark = 8,
                    //},
                    // new StudentSubject
                    //{
                    //    //Id = 21,
                    //    StudentID = 6,
                    //    SubjectID = 1,
                    //    Mark = 9,
                    //},
                    // new StudentSubject
                    //{
                    //   // Id = 22,
                    //    StudentID = 6,
                    //    SubjectID = 2,
                    //    Mark = 3,
                    //},
                    //   new StudentSubject
                    //{
                    //   // Id = 23,
                    //    StudentID = 6,
                    //    SubjectID = 3,
                    //    Mark = 4,
                    //},
                    // new StudentSubject
                    //{
                    //   // Id = 24,
                    //    StudentID = 6,
                    //    SubjectID = 4,
                    //    Mark = 7,
                    //},
            }
            );
            modelBuilder.Entity<Teacher>().HasData(
                new Teacher[]
                {
                    new Teacher
                    {
                        TeacherID = 1,
                        Name = "Maria Petrovna",
                        Phone = 8757393,
                        SubjectID = 1,
                    },
                    new Teacher
                    {
                        TeacherID = 2,
                        Name = "Vaniliy Krasnyj",
                        Phone = 1286367,
                        SubjectID = 1,
                    },
                     new Teacher
                    {
                        TeacherID = 3,
                        Name = "Olga Stepanovna",
                        Phone = 8545583,
                        SubjectID = 2,
                    },
                    new Teacher
                    {
                        TeacherID = 4,
                        Name = "Valentina Sergeevna",
                        Phone = 98784688,
                        SubjectID = 2,
                    },
                    new Teacher
                    {
                        TeacherID = 5,
                        Name = "Sergej Petrovich",
                        Phone = 8757393,
                        SubjectID = 3,
                    },
                    new Teacher
                    {
                        TeacherID = 6,
                        Name = "Marina Aleksandrovna",
                        Phone = 1286367,
                        SubjectID = 3,
                    },
                     new Teacher
                    {
                        TeacherID = 7,
                        Name = "Olga Aleksandrovna",
                        Phone = 8545583,
                        SubjectID = 4,
                    },
                    new Teacher
                    {
                        TeacherID = 8,
                        Name = "Valentina Aleksandrovna",
                        Phone = 98784688,
                        SubjectID = 4,
                    }
                }
                );
            modelBuilder.Entity<UniversityTeacher>().HasKey(p => new { p.UniversityID, p.TeacherID });
            modelBuilder.Entity<UniversityTeacher>().HasData(
                new UniversityTeacher[]
                {
                    new UniversityTeacher
                    {
                        Id = 1,
                        UniversityID = 1, 
                        TeacherID = 1,
                        Wage = 12345,
                    },
                     new UniversityTeacher
                    {
                        Id = 2,
                        UniversityID = 2,
                        TeacherID = 2,
                        Wage = 54321,
                    },
                      new UniversityTeacher
                    {
                        Id = 3,
                        UniversityID = 3,
                        TeacherID = 3,
                        Wage = 12345,
                    },
                    // new UniversityTeacher
                    //{
                    //    Id = 4,
                    //    UniversityID = 1,
                    //    TeacherID = 4,
                    //    Wage = 54321,
                    //},
                    //  new UniversityTeacher
                    //{
                    //    Id = 5,
                    //    UniversityID = 2,
                    //    TeacherID = 5,
                    //    Wage = 12345,
                    //},
                    // new UniversityTeacher
                    //{
                    //    Id = 6,
                    //    UniversityID = 3,
                    //    TeacherID = 6,
                    //    Wage = 54321,
                    //},
                    //  new UniversityTeacher
                    //{
                    //    Id = 7,
                    //    UniversityID = 1,
                    //    TeacherID = 7,
                    //    Wage = 12345,
                    //},
                    // new UniversityTeacher
                    //{
                    //    Id = 8,
                    //    UniversityID = 2,
                    //    TeacherID = 8,
                    //    Wage = 54321,
                    //},
                }
                );
        }
    }
}
