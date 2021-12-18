using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    internal class Teacher
    {
        public int TeacherID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
    }
}
