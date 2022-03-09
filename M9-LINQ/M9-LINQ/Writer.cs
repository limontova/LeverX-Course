using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UniversityDb.Model;

namespace M9_LINQ
{
    internal class Writer
    {
        public void  Write(IQueryable<Student> output, string task)
        {
            Console.WriteLine(task);
            foreach (var item in output)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("-------------------------------------------------------------------------");
        }
        public void Write(IQueryable<Student> output, string task, string oneMoreStringInTable, int maxBursary)
        {
            Console.WriteLine(task);
            foreach (var item in output)
            {
                Console.WriteLine($"{item} {oneMoreStringInTable} {100 * item.Bursary / maxBursary}");
            }
            Console.WriteLine("-------------------------------------------------------------------------");
        }
    }
}
