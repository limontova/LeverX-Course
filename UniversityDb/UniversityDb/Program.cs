using UniversityDb;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

class Program
{
    static void Main(string[] args)
    {
        UniversityContext context = new UniversityContext(); 
        context.Database.Migrate();
    }
}