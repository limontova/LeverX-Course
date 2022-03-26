using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestHomework.Models
{
    public class Group
    {
        public int GroupID { get; set; }
        public string? Name { get; set; }
        [JsonIgnore]
        public List<Student> Students { get; set; } = new List<Student>();
    }
}
