﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityDb;

#nullable disable

namespace UniversityDb.Migrations
{
    [DbContext(typeof(UniversityContext))]
    partial class UniversityContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UniversityDb.Model.City", b =>
                {
                    b.Property<int>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CityID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Population")
                        .HasColumnType("int");

                    b.HasKey("CityID");

                    b.ToTable("City");

                    b.HasData(
                        new
                        {
                            CityID = 1,
                            Name = "Minsk",
                            Population = 123456
                        },
                        new
                        {
                            CityID = 2,
                            Name = "Brest",
                            Population = 1234
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.Group", b =>
                {
                    b.Property<int>("GroupID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UniversityID")
                        .HasColumnType("int");

                    b.HasKey("GroupID");

                    b.HasIndex("UniversityID");

                    b.ToTable("Group");

                    b.HasData(
                        new
                        {
                            GroupID = 1,
                            Name = "First",
                            UniversityID = 1
                        },
                        new
                        {
                            GroupID = 2,
                            Name = "Second",
                            UniversityID = 1
                        },
                        new
                        {
                            GroupID = 3,
                            Name = "Third",
                            UniversityID = 1
                        },
                        new
                        {
                            GroupID = 4,
                            Name = "First",
                            UniversityID = 2
                        },
                        new
                        {
                            GroupID = 5,
                            Name = "Second",
                            UniversityID = 2
                        },
                        new
                        {
                            GroupID = 6,
                            Name = "Third",
                            UniversityID = 3
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("datetime2");

                    b.Property<int>("Bonus")
                        .HasColumnType("int");

                    b.Property<int>("Bursary")
                        .HasColumnType("int");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<int?>("GroupID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StudentID");

                    b.HasIndex("CityID");

                    b.HasIndex("GroupID");

                    b.ToTable("Student");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            Birthday = new DateTime(2000, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1000,
                            CityID = 1,
                            GroupID = 1,
                            Name = "Sasha"
                        },
                        new
                        {
                            StudentID = 2,
                            Birthday = new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 30,
                            Bursary = 120,
                            CityID = 1,
                            GroupID = 1,
                            Name = "Masha"
                        },
                        new
                        {
                            StudentID = 3,
                            Birthday = new DateTime(2000, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1200,
                            CityID = 1,
                            GroupID = 1,
                            Name = "Misha"
                        },
                        new
                        {
                            StudentID = 4,
                            Birthday = new DateTime(2001, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 15,
                            Bursary = 500,
                            CityID = 1,
                            GroupID = 2,
                            Name = "Oksana"
                        },
                        new
                        {
                            StudentID = 5,
                            Birthday = new DateTime(2000, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1000,
                            CityID = 1,
                            GroupID = 3,
                            Name = "Sasha"
                        },
                        new
                        {
                            StudentID = 6,
                            Birthday = new DateTime(1999, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 30,
                            Bursary = 120,
                            CityID = 1,
                            GroupID = 3,
                            Name = "Masha"
                        },
                        new
                        {
                            StudentID = 7,
                            Birthday = new DateTime(1998, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1200,
                            CityID = 1,
                            GroupID = 6,
                            Name = "Misha"
                        },
                        new
                        {
                            StudentID = 8,
                            Birthday = new DateTime(1999, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 15,
                            Bursary = 500,
                            CityID = 1,
                            GroupID = 6,
                            Name = "Olga"
                        },
                        new
                        {
                            StudentID = 9,
                            Birthday = new DateTime(2000, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1000,
                            CityID = 1,
                            GroupID = 2,
                            Name = "Sasha"
                        },
                        new
                        {
                            StudentID = 10,
                            Birthday = new DateTime(2000, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 30,
                            Bursary = 120,
                            CityID = 1,
                            GroupID = 6,
                            Name = "Masha"
                        },
                        new
                        {
                            StudentID = 11,
                            Birthday = new DateTime(2000, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1200,
                            CityID = 1,
                            GroupID = 4,
                            Name = "Lesha"
                        },
                        new
                        {
                            StudentID = 12,
                            Birthday = new DateTime(2001, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 15,
                            Bursary = 500,
                            CityID = 1,
                            GroupID = 4,
                            Name = "Ulyana"
                        },
                        new
                        {
                            StudentID = 13,
                            Birthday = new DateTime(2000, 3, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1000,
                            CityID = 1,
                            GroupID = 4,
                            Name = "Sergey"
                        },
                        new
                        {
                            StudentID = 14,
                            Birthday = new DateTime(1999, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 30,
                            Bursary = 120,
                            CityID = 1,
                            GroupID = 4,
                            Name = "Danya"
                        },
                        new
                        {
                            StudentID = 15,
                            Birthday = new DateTime(1998, 7, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 20,
                            Bursary = 1200,
                            CityID = 1,
                            GroupID = 5,
                            Name = "Valya"
                        },
                        new
                        {
                            StudentID = 16,
                            Birthday = new DateTime(2002, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Bonus = 15,
                            Bursary = 500,
                            CityID = 2,
                            GroupID = 5,
                            Name = "Petr"
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.StudentSubject", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.Property<int>("Mark")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "SubjectID");

                    b.HasIndex("StudentID")
                        .IsUnique();

                    b.HasIndex("SubjectID")
                        .IsUnique();

                    b.ToTable("StudentSubject");

                    b.HasData(
                        new
                        {
                            StudentID = 1,
                            SubjectID = 1,
                            Mark = 8
                        },
                        new
                        {
                            StudentID = 1,
                            SubjectID = 2,
                            Mark = 9
                        },
                        new
                        {
                            StudentID = 1,
                            SubjectID = 3,
                            Mark = 10
                        },
                        new
                        {
                            StudentID = 1,
                            SubjectID = 4,
                            Mark = 7
                        },
                        new
                        {
                            StudentID = 2,
                            SubjectID = 1,
                            Mark = 5
                        },
                        new
                        {
                            StudentID = 2,
                            SubjectID = 2,
                            Mark = 9
                        },
                        new
                        {
                            StudentID = 2,
                            SubjectID = 3,
                            Mark = 10
                        },
                        new
                        {
                            StudentID = 2,
                            SubjectID = 4,
                            Mark = 6
                        },
                        new
                        {
                            StudentID = 3,
                            SubjectID = 1,
                            Mark = 7
                        },
                        new
                        {
                            StudentID = 3,
                            SubjectID = 2,
                            Mark = 7
                        },
                        new
                        {
                            StudentID = 3,
                            SubjectID = 3,
                            Mark = 7
                        },
                        new
                        {
                            StudentID = 3,
                            SubjectID = 4,
                            Mark = 10
                        },
                        new
                        {
                            StudentID = 4,
                            SubjectID = 1,
                            Mark = 10
                        },
                        new
                        {
                            StudentID = 4,
                            SubjectID = 2,
                            Mark = 7
                        },
                        new
                        {
                            StudentID = 4,
                            SubjectID = 3,
                            Mark = 10
                        },
                        new
                        {
                            StudentID = 4,
                            SubjectID = 4,
                            Mark = 10
                        },
                        new
                        {
                            StudentID = 5,
                            SubjectID = 1,
                            Mark = 8
                        },
                        new
                        {
                            StudentID = 5,
                            SubjectID = 2,
                            Mark = 8
                        },
                        new
                        {
                            StudentID = 5,
                            SubjectID = 3,
                            Mark = 8
                        },
                        new
                        {
                            StudentID = 5,
                            SubjectID = 4,
                            Mark = 8
                        },
                        new
                        {
                            StudentID = 6,
                            SubjectID = 1,
                            Mark = 9
                        },
                        new
                        {
                            StudentID = 6,
                            SubjectID = 2,
                            Mark = 3
                        },
                        new
                        {
                            StudentID = 6,
                            SubjectID = 3,
                            Mark = 4
                        },
                        new
                        {
                            StudentID = 6,
                            SubjectID = 4,
                            Mark = 7
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.Subject", b =>
                {
                    b.Property<int>("SubjectID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SubjectID"), 1L, 1);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubjectID");

                    b.ToTable("Subject");

                    b.HasData(
                        new
                        {
                            SubjectID = 1,
                            Duration = 60,
                            Name = "Math"
                        },
                        new
                        {
                            SubjectID = 2,
                            Duration = 80,
                            Name = "Russian"
                        },
                        new
                        {
                            SubjectID = 3,
                            Duration = 60,
                            Name = "Belarusian"
                        },
                        new
                        {
                            SubjectID = 4,
                            Duration = 80,
                            Name = "English"
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.Teacher", b =>
                {
                    b.Property<int>("TeacherID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TeacherID"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Phone")
                        .HasColumnType("int");

                    b.Property<int>("SubjectID")
                        .HasColumnType("int");

                    b.HasKey("TeacherID");

                    b.HasIndex("SubjectID");

                    b.ToTable("Teacher");

                    b.HasData(
                        new
                        {
                            TeacherID = 1,
                            Name = "Maria Petrovna",
                            Phone = 8757393,
                            SubjectID = 1
                        },
                        new
                        {
                            TeacherID = 2,
                            Name = "Vaniliy Krasnyj",
                            Phone = 1286367,
                            SubjectID = 1
                        },
                        new
                        {
                            TeacherID = 3,
                            Name = "Olga Stepanovna",
                            Phone = 8545583,
                            SubjectID = 2
                        },
                        new
                        {
                            TeacherID = 4,
                            Name = "Valentina Sergeevna",
                            Phone = 98784688,
                            SubjectID = 2
                        },
                        new
                        {
                            TeacherID = 5,
                            Name = "Sergej Petrovich",
                            Phone = 8757393,
                            SubjectID = 3
                        },
                        new
                        {
                            TeacherID = 6,
                            Name = "Marina Aleksandrovna",
                            Phone = 1286367,
                            SubjectID = 3
                        },
                        new
                        {
                            TeacherID = 7,
                            Name = "Olga Aleksandrovna",
                            Phone = 8545583,
                            SubjectID = 4
                        },
                        new
                        {
                            TeacherID = 8,
                            Name = "Valentina Aleksandrovna",
                            Phone = 98784688,
                            SubjectID = 4
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.University", b =>
                {
                    b.Property<int>("UniversityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UniversityID"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CityID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UniversityID");

                    b.HasIndex("CityID");

                    b.ToTable("University");

                    b.HasData(
                        new
                        {
                            UniversityID = 1,
                            Address = "address1",
                            CityID = 1,
                            Name = "BSUIR"
                        },
                        new
                        {
                            UniversityID = 2,
                            Address = "address2",
                            CityID = 1,
                            Name = "BSU"
                        },
                        new
                        {
                            UniversityID = 3,
                            Address = "address3",
                            CityID = 2,
                            Name = "BSUSTT"
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.UniversityTeacher", b =>
                {
                    b.Property<int>("UniversityID")
                        .HasColumnType("int");

                    b.Property<int>("TeacherID")
                        .HasColumnType("int");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("Wage")
                        .HasColumnType("int");

                    b.HasKey("UniversityID", "TeacherID");

                    b.HasIndex("TeacherID")
                        .IsUnique();

                    b.HasIndex("UniversityID")
                        .IsUnique();

                    b.ToTable("UniversityTeacher");

                    b.HasData(
                        new
                        {
                            UniversityID = 1,
                            TeacherID = 1,
                            Id = 1,
                            Wage = 12345
                        },
                        new
                        {
                            UniversityID = 2,
                            TeacherID = 2,
                            Id = 2,
                            Wage = 54321
                        },
                        new
                        {
                            UniversityID = 3,
                            TeacherID = 3,
                            Id = 3,
                            Wage = 12345
                        });
                });

            modelBuilder.Entity("UniversityDb.Model.Group", b =>
                {
                    b.HasOne("UniversityDb.Model.University", "University")
                        .WithMany("Groups")
                        .HasForeignKey("UniversityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("University");
                });

            modelBuilder.Entity("UniversityDb.Model.Student", b =>
                {
                    b.HasOne("UniversityDb.Model.City", "City")
                        .WithMany("Students")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityDb.Model.Group", "Group")
                        .WithMany("Students")
                        .HasForeignKey("GroupID");

                    b.Navigation("City");

                    b.Navigation("Group");
                });

            modelBuilder.Entity("UniversityDb.Model.StudentSubject", b =>
                {
                    b.HasOne("UniversityDb.Model.Student", "Student")
                        .WithOne("StudentSubject")
                        .HasForeignKey("UniversityDb.Model.StudentSubject", "StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityDb.Model.Subject", "Subject")
                        .WithOne("StudentSubject")
                        .HasForeignKey("UniversityDb.Model.StudentSubject", "SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("UniversityDb.Model.Teacher", b =>
                {
                    b.HasOne("UniversityDb.Model.Subject", "Subject")
                        .WithMany("Teachers")
                        .HasForeignKey("SubjectID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("UniversityDb.Model.University", b =>
                {
                    b.HasOne("UniversityDb.Model.City", "City")
                        .WithMany("Universities")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("UniversityDb.Model.UniversityTeacher", b =>
                {
                    b.HasOne("UniversityDb.Model.Teacher", "Teacher")
                        .WithOne("UniversityTeachers")
                        .HasForeignKey("UniversityDb.Model.UniversityTeacher", "TeacherID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityDb.Model.University", "Universitiy")
                        .WithOne("UniversityTeacher")
                        .HasForeignKey("UniversityDb.Model.UniversityTeacher", "UniversityID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Teacher");

                    b.Navigation("Universitiy");
                });

            modelBuilder.Entity("UniversityDb.Model.City", b =>
                {
                    b.Navigation("Students");

                    b.Navigation("Universities");
                });

            modelBuilder.Entity("UniversityDb.Model.Group", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("UniversityDb.Model.Student", b =>
                {
                    b.Navigation("StudentSubject");
                });

            modelBuilder.Entity("UniversityDb.Model.Subject", b =>
                {
                    b.Navigation("StudentSubject");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("UniversityDb.Model.Teacher", b =>
                {
                    b.Navigation("UniversityTeachers");
                });

            modelBuilder.Entity("UniversityDb.Model.University", b =>
                {
                    b.Navigation("Groups");

                    b.Navigation("UniversityTeacher");
                });
#pragma warning restore 612, 618
        }
    }
}
