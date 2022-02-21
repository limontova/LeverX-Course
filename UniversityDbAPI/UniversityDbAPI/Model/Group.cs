using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class Group
    {
        public int GroupID { get; set; }
        public string Name { get; set; }
        public int UniversityID { get; set; }
        public University University { get; set; } = new University();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
