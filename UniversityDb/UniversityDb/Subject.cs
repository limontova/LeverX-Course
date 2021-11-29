using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class Subject
    {
        public Subject()
        {
            Name = string.Empty;
            Duration = string.Empty;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Duration { get; set; }
    }
}
