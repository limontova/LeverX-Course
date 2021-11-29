using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversityDb
{
    internal class University
    {
        public University()
        {
            Name = string.Empty;
            Address = string.Empty;
        }
        public University(int id, string name, string address, int cityId)
        {
            ID = id;
            Name = name;
            Address = address;
            CityId = cityId;
        }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int CityId { get; set; }

    }
}
