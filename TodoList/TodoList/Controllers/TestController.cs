using Microsoft.AspNetCore.Mvc;
using TodoList.Models;
using TodoList.Models.ViewModels;

namespace TodoList.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            Todo todo = new Todo("Estudar Asp.NET", "Estudo de ASP.NET", DateTime.Now);
            return View(todo);
        }
    }
}
