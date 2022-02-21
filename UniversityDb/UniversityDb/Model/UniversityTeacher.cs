using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class UniversityTeacher
    {
        public int Id { get; set; }
        public int UniversityID { get; set; }
        public University Universitiy { get; set; } = new University();

        public int TeacherID { get; set; }
        public Teacher Teacher { get; set; } = new Teacher();
        public int Wage { get; set; }
    }
}
