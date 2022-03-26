using Microsoft.AspNetCore.Mvc;
using RestHomework.Models;

namespace RestHomework.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class GroupsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Group> Get()
        {
            return StaticData.Groups;
        }

        [HttpGet("{id}")]
        public Group Get([FromRoute] int id)
        {
            return StaticData.Groups.FirstOrDefault(x => x.GroupID == id);
        }

        [HttpPost]
        public void Post([FromBody] Group value)
        {
            StaticData.Groups.Add(value);
        }

        [HttpPut("{id}")]
        public void Put([FromRoute] int id, [FromBody] Group value)
        {
            var group = StaticData.Groups.FirstOrDefault(x => x.GroupID == id);
            group.Name = value.Name;
        }

        [HttpDelete("{id}")]
        public void Delete([FromRoute] int id)
        {
            StaticData.Groups.Remove(StaticData.Groups.FirstOrDefault(x => x.GroupID == id));
        }
    }
}
