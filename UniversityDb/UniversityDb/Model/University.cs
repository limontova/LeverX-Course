using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class University
    {
        public int UniversityID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityID { get; set; }
        public City City { get; set; }
        public List<UniversityTeacher> Teachers { get; set; } = new List<UniversityTeacher>();
        public List<Group> Groups { get; set; } = new List<Group>();
    }
}
