using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class UniversityTeacher
    {
        public int ID { get; set; }
        [ForeignKey("Teacher")]
        public int TeacherID { get; set; }
        [ForeignKey("University")]
        public int UniversityID { get; set; }
        public int Wage { get; set; }

    }
}
