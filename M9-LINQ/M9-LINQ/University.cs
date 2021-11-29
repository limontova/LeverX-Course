using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class University
    {
        public University()
        {
            universityTeachers = new List<UniversityTeacher>();
            group = new List<Group>();
        }
        public ICollection<UniversityTeacher> universityTeachers { get; set; }
        public ICollection<Group> group { get; set; }
        public int UniversityId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }

    }
}
