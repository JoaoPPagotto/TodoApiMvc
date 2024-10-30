using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using WebAplication01.TodoListMvc.Context;
using WebAplication01.TodoListMvc.Contracts;
using WebAplication01.TodoListMvc.Model;
using WebAplication01.TodoListMvc.Repository;

namespace WebAplication01.TodoListMvc.Services
{
    public class TodoServices : ITodo
    {
        private readonly TodoRepository _todoRepository;

        public TodoServices(TodoRepository todoRepository)
        {
            _todoRepository = todoRepository;
        }

        public Todo Create(Todo todo)
        {
            return _todoRepository.Create(todo);
        }

        public void Delete(int id)
        {
            _todoRepository.Delete(id);
        }

        public IEnumerable<Todo> Search()
        {
            return _todoRepository.GetAll().ToList();
        }

        public Todo SearchById(int id)
        {
            return _todoRepository.GetById(id);
        }

        public IEnumerable<Todo> SearchComplete()
        {
            return _todoRepository.GetAll().Where(todo => todo.IsComplete);
        }

        public Todo Update(int id, Todo todo)
        {
            return _todoRepository.Update(id, todo);
        }
    }
}
