using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class Group
    {
        public Group()
        {
            students = new List<Student>();
        }
        public int GroupId { get; set; }
        public string Name { get; set; }
        [ForeignKey("University")]
        public int UniversityID { get; set; }
        public University University { get; set;}
        public ICollection<Student> students { get; set; }
    }
}
