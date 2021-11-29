using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class City
    {
        public City()
        {
            Name = string.Empty;
        }
        public int CityId { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
    }
}
