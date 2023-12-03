using Microsoft.AspNetCore.Mvc;
using TodoList.Database;
using TodoList.Models;
using TodoList.Models.ViewModels;

namespace TodoList.Controllers
{
    public class TodoController : Controller
    {
        private readonly TodoContext _todoContext;

        public TodoController(TodoContext todoContext)
        {
            _todoContext = todoContext;
        }

        public IActionResult Index()
        {
            ViewData["Title"] = "Lista de Tarefas";

            List<Todo> list = _todoContext.Todos.ToList();
            ListTodoViewModel viewModel = new ListTodoViewModel { Todos = list };

            return View(viewModel);
        }
    }
}
