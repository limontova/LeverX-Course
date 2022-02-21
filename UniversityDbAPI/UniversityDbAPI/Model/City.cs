using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb.Model
{
    public class City
    {
        public int CityID { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public List<University> Universities { get; set; } = new List<University>();
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
