using WebAplication01.TodoListMvc.Context;
using WebAplication01.TodoListMvc.Model;

namespace WebAplication01.TodoListMvc.Contracts
{
    public interface ITodo
    {
        IEnumerable<Todo> Search();
        IEnumerable<Todo> SearchComplete();
        Todo SearchById(int id);
        Todo Create(Todo todo);
        Todo Update(int id, Todo todo);
        void Delete(int id);
    }
}
