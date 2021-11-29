using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class Student
    {
        public Student()
        {
            Name = string.Empty;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Bursary { get; set; }
        public int Bonus { get; set; }
        public int CityID { get; set; }
        public int GroupID { get; set; }
    }
}
