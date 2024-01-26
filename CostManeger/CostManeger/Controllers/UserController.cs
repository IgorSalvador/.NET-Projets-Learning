using CostManeger.Database;
using CostManeger.Models;
using CostManeger.Models.Utils;
using CostManeger.Models.ViewModels.User;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CostManeger.Controllers
{
    [Authorize(Roles = "Administrator")]
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
            string password = string.Empty, encryptedPassword = string.Empty;

            if (!ModelState.IsValid)
            {
                return View(model);
            }

            #region Remove masks

            model.CPF = !string.IsNullOrEmpty(model.CPF) ? model.CPF.Replace(".", "").Replace("-", "") : string.Empty;

            #endregion

            password = Password.GenerateRandomPassword();
            encryptedPassword = MD5Encryption.GetMD5Hash(password);

            Usuario usuario = new Usuario(model, encryptedPassword);
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            return RedirectToAction(nameof(Index), nameof(User));
        }
    }
}
