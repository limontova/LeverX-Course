using UniversityDb;
using Microsoft.EntityFrameworkCore;
using UniversityDb.Model;
using M9_LINQ;

class Program
{
    static void Main(string[] args)
    {
        UniversityContext context = new UniversityContext();
        context.SaveChanges();
        context.Database.Migrate();

        Writer writer = new Writer();
        //1.Select all Students from groups 1, 5, 6.
        //using LINQ:
        try
        {
            var selectedStudents = from s in context.Student
                                   where s.Group.GroupID == 1 || s.Group.GroupID == 5 || s.Group.GroupID == 6
                                   select s;
            writer.Write(selectedStudents, "Select all Students from groups 1, 5, 6.");
            
        }catch(Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //using extensions:

        //2.Select all Students from groups 2, 4, 6 who has bursary more than 600.
        //using LINQ:
        try
        {
            var selectedStudents = from s in context.Student
                                   where (s.Group.GroupID == 2 || s.Group.GroupID == 4 || s.Group.GroupID == 6) && s.Bursary > 600
                                   select s;
            writer.Write(selectedStudents, "Select all Students from groups 2, 4, 6 who has bursary more than 600.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //3.Select all students with name starts with “D” with average mark from 7.4 to 9.5.
        //using LINQ:
        try
        {
            var selectedStudents = from ss in context.StudentSubject
                                   join s in context.Student on ss.StudentID equals s.StudentID
                                   where (s.Name.ToUpper().StartsWith("D") && (ss.Mark > 7.4 && ss.Mark < 9.5))
                                   select s;
            writer.Write(selectedStudents, "Select all students with name starts with “D” with average mark from 7.4 to 9.5.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //4.Select all students with last letter name “a” and date of birth should be in the following format DD MM YYYY(e.g. 13 апр 1990).
        try
        {
            var selectedStudents = from s in context.Student
                                   where (s.Name.ToUpper().EndsWith("a"))
                                   select s;
            writer.Write(selectedStudents, "Select all students with last letter name “a” and date of birth should be in the following format DD MM YYYY(e.g. 13 апр 1990).");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //5.Select all students who gets bursary bonus and who’s date of birth after Jan 1, 1988.
        try
        {
            DateTime date = new DateTime(1998, 1, 1);
            var selectedStudents = from s in context.Student
                                   where (s.Bonus > 0 && s.Birthday.CompareTo(date) > 0)
                                   select s;
            writer.Write(selectedStudents, "Select all students who gets bursary bonus and who’s date of birth after Jan 1, 1988.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //6.Show unique bursaries of students from Brest.
        try
        {
            var selectedStudents = from s in context.Student
                                   join c in context.City on s.CityID equals c.CityID
                                   where (c.Name == "Brest")
                                   select s;
            writer.Write(selectedStudents, "Show unique bursaries of students from Brest.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //7.Select all students from Minsk and sort them by income.
        try
        {
            var selectedStudents = from s in context.Student
                                   join c in context.City on s.CityID equals c.CityID
                                   where (c.Name == "Minsk")
                                   orderby s.Bursary
                                   select s;
            writer.Write(selectedStudents, "Select all students from Minsk and sort them by income.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //8.Select all students whose date of birth from Jan 1, 1990 to Jan 1, 1991, city where are they from and sort them by income descending.
        try
        {
            DateTime firstDate = new DateTime(1990, 1, 1);
            DateTime secondDate = new DateTime(1991, 1, 1);
            var selectedStudents = from s in context.Student
                                   join c in context.City on s.CityID equals c.CityID
                                   where (s.Birthday.CompareTo(firstDate) > 0 && s.Birthday.CompareTo(firstDate) < 0)
                                   orderby s.Bursary descending
                                   select s;
            writer.Write(selectedStudents, "Select all students whose date of birth from Jan 1, 1990 to Jan 1, 1991, city where are they from and sort them by income descending.");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        //9.Select students from group First and their bursary like a percent from max bursary.
        //(e.g.
        //| Name | Bursary Percent |
        //| Ivan | 50 % (percent) |
        //)
        try
        {
            var selectedStudents = from s in context.Student
                                   join g in context.Group on s.GroupID equals g.GroupID
                                   where (g.Name == "First")
                                   orderby s.Bursary descending
                                   select s;
            var maxBursary = selectedStudents.First().Bursary;
            writer.Write(selectedStudents, "Select students from group First and their bursary like a percent from max bursary.", "Percent from max bursary: ", maxBursary);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

    }
}