using Microsoft.AspNetCore.Mvc;

namespace CostManeger.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
