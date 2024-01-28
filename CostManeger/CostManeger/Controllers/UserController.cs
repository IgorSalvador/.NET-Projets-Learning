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
        public IActionResult Create(CreateUserViewModel model)
        {
            ViewData["ProfileOptions"] = context.Perfis.Where(p => p.IsActive).ToList();
            string password = string.Empty, encryptedPassword = string.Empty;

            if (!ModelState.IsValid)
                return View(model);

            #region Remove masks

            model.CPF = !string.IsNullOrEmpty(model.CPF) ? model.CPF.Replace(".", "").Replace("-", "") : string.Empty;

            #endregion

            password = Password.GenerateRandomPassword();
            encryptedPassword = MD5Encryption.GetMD5Hash(password);

            Users usuario = new Users(model, encryptedPassword);
            context.Usuarios.Add(usuario);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewData["ProfileOptions"] = context.Perfis.Where(p => p.IsActive).ToList();

            Users usuario = context.Usuarios.Find(id)!;

            if (usuario == null)
                return NotFound();

            return View(new EditUserViewModel(usuario));
        }

        [HttpPost]
        public IActionResult Edit(EditUserViewModel model)
        {
            ViewData["ProfileOptions"] = context.Perfis.Where(p => p.IsActive).ToList();

            if (!ModelState.IsValid)
                return View(model);

            Users usuario = context.Usuarios.Find(model.Id)!;

            usuario.Name = model.Name;
            usuario.Surname = model.Surname;
            usuario.Email = model.Email;
            usuario.Phone = model.PhoneNumber;
            usuario.BirthDate = model.BirthDate;
            usuario.CPF = !string.IsNullOrEmpty(model.CPF) ? model.CPF.Replace(".", "").Replace("-", "") : string.Empty;
            usuario.RG = usuario.RG;
            usuario.Profile = model.Profile;
            usuario.IsActive = model.IsActive;

            context.Entry(usuario).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Users usuario = context.Usuarios.Find(id)!;

            if (usuario == null)
                return NotFound();

            context.Usuarios.Remove(usuario);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
