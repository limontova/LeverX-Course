using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public List<Teacher> Teachers { get; set; } = new List<Teacher>();
        public List<StudentSubject> StudentSubject { get; set; } = new List<StudentSubject>();
    }
}
