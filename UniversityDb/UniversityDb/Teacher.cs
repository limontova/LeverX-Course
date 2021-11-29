using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class Teacher
    {
        public Teacher()
        {
            Name = string.Empty;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public int SubjectID { get; set; }
    }
}
