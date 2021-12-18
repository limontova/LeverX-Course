using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    internal class Subject
    {
        public int SubjectID { get; set; }
        public string Name { get; set; }
        public TimeOnly Duration { get; set; }
        public List<Teacher> Teachers { get; set; }
    }
}
