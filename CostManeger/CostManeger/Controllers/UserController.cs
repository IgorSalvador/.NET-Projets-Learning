using CostManeger.Database;
using CostManeger.Models.Utils;
using CostManeger.Models.ViewModels.User;
using Microsoft.AspNetCore.Mvc;

namespace CostManeger.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDbContext context;

        public UserController(AppDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Usuarios.ToList().OrderBy(x => x.Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["ProfileOptions"] = context.Perfis.Where(p => p.IsActive).ToList();

            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            ViewData["ProfileOptions"] = context.Perfis.Where(p => p.IsActive).ToList();

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            return View();
        }
    }
}
