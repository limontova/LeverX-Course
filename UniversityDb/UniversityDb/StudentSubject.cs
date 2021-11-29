using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class StudentSubject
    {
        public int ID { get; set; }
        public int StudentID { get; set; }
        public int SubjectID { get; set; }
        public int Mark { get; set; }
    }
}
