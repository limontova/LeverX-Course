using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    internal class StudentSubject
    {
        public int StudentID { get; set; }
        public Student Student { get; set; }
        public int SubjectID { get; set; }
        public Subject Subject { get; set; }
        public int Mark { get; set; }
    }
}
