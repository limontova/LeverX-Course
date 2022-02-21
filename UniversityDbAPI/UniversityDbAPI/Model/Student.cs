using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Bursary { get; set; }
        public int Bonus { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public int GroupID { get; set; }
        public Group Group { get; set; }
    }
}
