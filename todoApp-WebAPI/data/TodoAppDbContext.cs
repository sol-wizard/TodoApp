
using Microsoft.EntityFrameworkCore;
using todoApp_WebAPI.data.entities;

namespace todoApp_WebAPI.data
{
    public class TodoAppDbContext : DbContext
    {
        public TodoAppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<TodoItem> TodoItems {get; set;}
    }
}