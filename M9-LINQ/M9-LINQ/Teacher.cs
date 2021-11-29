using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int TeacherId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        [ForeignKey("Subject")]
        public int SubjectID { get; set; }
    }
}
