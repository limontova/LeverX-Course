using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int StudentId { get; set; }
        public string Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Bursary { get; set; }
        public int Bonus { get; set; }
        [ForeignKey("City")]
        public int CityID { get; set; }
        public int? UniversityId { get; set; }
        public Group Group { get; set; }
    }
}
