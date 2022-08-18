


using Microsoft.AspNetCore.Mvc;
using TodosApi.Dtos;

namespace TodosApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TodoController : Controller
    {
        private static List<Todo> todos = new();

        [HttpGet] // GET
        public async Task<ActionResult<List<Todo>>> GetTodos()
        {
            return Ok(todos);
        }

        [HttpGet("{id}")] // GET/ {id}
        public async Task<ActionResult<Todo>> GetTodo(Guid? id)
        {
            var todo = todos.Where(todo => todo.Id == id);
            if (todo == null) return BadRequest(String.Format("we could not found the todo {0}", id));
            return Ok(todo);
        }

        [HttpPost] // POST
        public async Task<ActionResult<Todo>> CreateTodo(CreateTodo todo)
        {
            if (todo.Title == "" || todo.Title == null) return BadRequest("Todo title can not be empty...");
            
            Todo newTodo = new()
            {
                Id = Guid.NewGuid(),
                Title = todo.Title,
                Completed = false,
            };

            todos.Add(newTodo);
            return Ok(newTodo);
        }

        [HttpPut("{id}/title")] // PUT/{id}/title
        public async Task<ActionResult<Todo>> UpdateTitleTodo(Guid id, UpdateTitleTodo uTodo)
        {
            var eTodo = todos.Find(eTodo => eTodo.Id == id);

            if (eTodo == null) return NotFound();
            if (uTodo.Title != null && uTodo.Title != eTodo.Title) eTodo.Title = uTodo.Title;

            return Ok(eTodo);
        }

        [HttpPut("{id}/completed")] // PUT/{id}/completed
        public async Task<ActionResult<Todo>> UpdateStatusTodo(Guid id, UpdateStatusTodo uTodo)
        {
            var eTodo = todos.Find(eTodo => eTodo.Id == id);

            if (eTodo == null) return NotFound();
            if (uTodo.Completed != eTodo.Completed) eTodo.Completed = uTodo.Completed;

            return Ok(eTodo);
        }

        [HttpDelete("{id}")] // DELETE/{id}
        public async Task<ActionResult<Todo>> DeleteTodo(Guid id)
        {
            var eTodo = todos.Find(eTodo => eTodo.Id == id);

            if (eTodo == null) return NotFound();
            todos.Remove(eTodo);

            return Ok(eTodo);
        }

    }
}
