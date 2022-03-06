using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class StudentSubject
    {
        public int Id { get; set; }
        //[Key]
        public int StudentID { get; set; }
        public Student? Student { get; set; }
       // [Key]
        public int SubjectID { get; set; }
        public Subject? Subject { get; set; }
        public int Mark { get; set; }
    }
}
