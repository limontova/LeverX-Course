using UniversityDb;
using Microsoft.EntityFrameworkCore;
using UniversityDb.Model;

class Program
{
    static void Main(string[] args)
    {
        UniversityContext context = new UniversityContext();
        context.SaveChanges();
        context.Database.Migrate();
    }
}