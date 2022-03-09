using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Bursary { get; set; }
        public int Bonus { get; set; }
        public int CityID { get; set; }
        public City? City { get; set; }
        public int? GroupID { get; set; }
        public Group? Group { get; set; }
        public StudentSubject? StudentSubject { get; set; }
        //public List<StudentSubject> StudentSubject { get; set; } = new List<StudentSubject>();
    }
}
