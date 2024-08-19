using Microsoft.AspNetCore.Mvc;
using Sandbox.Data.Models.Todo;
using Sandbox.Data.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Sandbox.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly IRepository<TodoItem> _todoRepository;

        public TodoController(IRepository<TodoItem> todoRepository)
        {
            _todoRepository = todoRepository;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TodoItem>> GetTodoItem(int id)
        {
            var product = await _todoRepository.GetByIdAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TodoItem>>> GetTodoItems()
        {
            var todos = await _todoRepository.GetAllAsync();
            return Ok(todos);
        }

        [HttpPost]
        public async Task<ActionResult<TodoItem>> AddTodo([FromBody] TodoItem todo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _todoRepository.AddAsync(todo);
            return CreatedAtAction(nameof(GetTodoItem), new { id = todo.Id }, todo);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTodoItem(int id, [FromBody] TodoItem todo)
        {
            if (id != todo.Id)
            {
                return BadRequest();
            }

            _todoRepository.Update(todo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTodoItem(int id)
        {
            var todoItem = await _todoRepository.GetByIdAsync(id);
            if (todoItem == null)
            {
                return NotFound();
            }

            _todoRepository.Delete(todoItem);
            return NoContent();
        }
    }
}
