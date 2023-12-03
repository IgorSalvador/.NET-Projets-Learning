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

        [HttpGet]
        public IActionResult Index()
        {
            ViewData["Title"] = "Lista de Tarefas";

            List<Todo> list = _todoContext.Todos.ToList();
            ListTodoViewModel viewModel = new ListTodoViewModel { Todos = list };

            return View(viewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "Cadastrar Tarefa";
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateTodoViewModel data)
        {
            Todo todo = new Todo(data.Title, data.Description, data.Date);

            _todoContext.Add(todo);
            _todoContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["Title"] = "Editar Tarefa";

            var todo = _todoContext.Todos.Find(id);

            if (todo is null)
                return NotFound();

            EditTodoViewModel viewModel = new EditTodoViewModel
            {
                Title = todo.Title,
                Description = todo.Description,
                Date = todo.Date,
            };

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, EditTodoViewModel data)
        {
            var todo = _todoContext.Todos.Find(id);

            if (todo is null)
                return NotFound();

            todo.Title = data.Title;
            todo.Description = data.Description;
            todo.Date = data.Date;

            _todoContext.Entry(todo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _todoContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult ToComplete(int id)
        {
            var todo = _todoContext.Todos.Find(id);

            if (todo is null)
                return NotFound();

            todo.IsCompleted = true;

            _todoContext.Entry(todo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _todoContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Delete(int id)
        {
            var todo = _todoContext.Todos.Find(id);

            if(todo is null)
                return NotFound();

            _todoContext.Remove(todo);
            _todoContext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
