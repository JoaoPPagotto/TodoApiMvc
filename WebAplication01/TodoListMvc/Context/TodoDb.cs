using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using WebAplication01.TodoListMvc.Model;

namespace WebAplication01.TodoListMvc.Context
{
    public class TodoDb : DbContext
    {
        public TodoDb(DbContextOptions<TodoDb> options)
        : base(options) { }

        public DbSet<Todo> Todos => Set<Todo>();
    }
}
