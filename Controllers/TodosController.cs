// using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
// using System.Threading.Tasks;

namespace todoapi.Controllers
{
   [Route("api/[controller]")]
    public class TodosController : Controller
    {
        private List<Todo> todos = new List<Todo>() {
            new Todo() { ID=0, Description="Get milk", Completed=true },
            new Todo() { ID=1, Description="Get pet food" },
            new Todo() { ID=2, Description="Learn .NET Core" },
            new Todo() { ID=3, Description="Write billion-dollar app" }
        };
    // GET api/todos
    [HttpGet]
    public IEnumerable<Todo> Get()
    {
        return todos;
    }
    // GET api/todos/5
    [HttpGet("{id}")]
    public Todo Get(int id)
    {
        return todos.First((t) => t.ID == id);
    }
    // POST api/todos
    [HttpPost]
    public void Post([FromBody]Todo value)
    {
        todos.Add(value);
    }

    // PUT api/todos/5
    [HttpPut("{id}")]
    public void Put(int id, [FromBody]Todo value)
    {
        var todo = todos.First((t) => t.ID == id);
        todo.Description = value.Description;
        todo.Completed = value.Completed;
    }
    // DELETE api/todos/5
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
    }
}
}