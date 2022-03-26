using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestHomework.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string? Name { get; set; }
        public DateTime Birthday { get; set; }
        public int Bursary { get; set; }
        public int Bonus { get; set; }
        //public int? GroupID { get; set; }
        //public Group? Group { get; set; }
        //public bool Equals(Student other)
        //{
        //    if (Object.ReferenceEquals(other, null)) return false;
        //    if (Object.ReferenceEquals(this, other)) return true;
        //    return Bursary.Equals(other.Bursary);
        //}
        //public override int GetHashCode()
        //{
        //    int hashBursary = Bursary.GetHashCode();
        //    return hashBursary;
        //}
        //public override string ToString()
        //{
        //    return nameof(StudentID) + ": " + StudentID.ToString() + '\n' +
        //           nameof(Name) + ": " + Name + '\n' +
        //           nameof(Birthday) + ": " + Birthday.ToString("dd MMMM yyyy") + '\n' +
        //           nameof(Bursary) + ": " + Bursary.ToString() + '\n' +
        //           nameof(Bonus) + ": " + Bonus.ToString() + '\n' +
        //           nameof(GroupID) + ": " + GroupID.ToString() + '\n';
        //}
    }
}
