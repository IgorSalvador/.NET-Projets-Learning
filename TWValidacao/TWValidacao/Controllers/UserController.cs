using Microsoft.AspNetCore.Mvc;
using TWValidacao.Models.ViewModel;

namespace TWValidacao.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Listagem de Usuário";
            return View();
        }

        public IActionResult Create()
        {
            ViewData["Title"] = "Cadastro de Usuário";
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateUserViewModel formData)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Title"] = "Cadastro de Usuário";
                return View(formData);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
