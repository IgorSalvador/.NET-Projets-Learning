using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.Models.ViewModels;

namespace TodoList.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ViewModel()
        {
            Todo todo = new Todo
            {
                Title = "Estudar ASP .NET Core",
                Description = "Concluir o curso de ASP .NET Core da TreinaWeb"
            };

            DetailsTodoViewModel viewModel = new DetailsTodoViewModel
            {
                Todo = todo,
                PageTitle = "Detalhes da Tarefa"
            };

            return View(viewModel);
        }
    }
}
