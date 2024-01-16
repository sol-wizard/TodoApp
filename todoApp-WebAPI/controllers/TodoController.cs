using Microsoft.AspNetCore.Mvc;
using todoApp_WebAPI.services;

namespace todoApp_WebAPI.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class TodoController : ControllerBase
    {
        private readonly TodoService _todoService;
        public TodoController(TodoService todoService)
        {
            _todoService = todoService;
        }

        [HttpGet("getWorkTasks")]
        public IActionResult GetTodoItems()
        {
            var todoItems = _todoService.GetTodoItems();
            return Ok(todoItems);
        }
    }
}
