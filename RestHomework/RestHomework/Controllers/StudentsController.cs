using Microsoft.AspNetCore.Mvc;
using RestHomework.Models;

namespace RestHomework.Controllers
{
    [ApiController]
    [Route("Group/{groupId}/[controller]")]
    public class StudentsController : ControllerBase
    {
        [HttpGet()]
        public IEnumerable<Student> Get([FromRoute] int groupId)
        {
            return StaticData.Groups.FirstOrDefault(x => x.GroupID == groupId).Students;
        }

        [HttpGet("{id}")]
        public Student Get([FromRoute] int groupId, [FromRoute] int id)
        {
            return StaticData.Groups.FirstOrDefault(x => x.GroupID == groupId).Students.FirstOrDefault(x => x.StudentID == id);
        }

        [HttpPost]
        public void Post([FromRoute] int groupId, [FromBody] Student value)
        {
            StaticData.Groups.FirstOrDefault(x => x.GroupID == groupId).Students.Add(value);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int groupId, [FromRoute] int id, [FromBody] Student value)
        {
            var student = StaticData.Groups.FirstOrDefault(x => x.GroupID == groupId).Students.FirstOrDefault(x => x.StudentID == id);
            student.Name = value.Name;
            student.Bursary = value.Bursary;
            student.Birthday = value.Birthday;
            student.Bonus = value.Bonus;
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int groupId, [FromRoute] int id)
        {
            var students = StaticData.Groups.FirstOrDefault(x => x.GroupID == groupId).Students;
            students.Remove(students.FirstOrDefault(x => x.StudentID == id));
        }
    }
}
