using todoApp_WebAPI.data;
using todoApp_WebAPI.models;

namespace todoApp_WebAPI.services
{
    public class TodoService
    {
        private readonly TodoAppDbContext _dbContext;
        public TodoService(TodoAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<TodoItemDTO> GetTodoItems()
        {
            return _dbContext.TodoItems
                        .Select(x => new TodoItemDTO
                        {
                            Title = x.Title,
                            isDone = x.isDone
                        }).ToList();;
        }
    }
}