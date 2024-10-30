
using Microsoft.EntityFrameworkCore;
using WebAplication01.TodoListMvc.Context;
using WebAplication01.TodoListMvc.Contracts;
using WebAplication01.TodoListMvc.Repository;
using WebAplication01.TodoListMvc.Services;

namespace WebAplication01.TodoListMvc
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllers();
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddDbContext<TodoDb>(opt => opt.UseInMemoryDatabase("TodoList"));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            //Toda vez que for pedido um ITodo, cria uma inst�ncia de TodoService.
            builder.Services.AddScoped<ITodo, TodoServices>();

            builder.Services.AddScoped<TodoRepository, TodoRepository>();

            var app = builder.Build();

            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}