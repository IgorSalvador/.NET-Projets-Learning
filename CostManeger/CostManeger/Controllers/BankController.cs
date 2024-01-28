using CostManeger.Database;
using CostManeger.Models;
using CostManeger.Models.ViewModels.Bank;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CostManeger.Controllers
{
    [Authorize(Roles = "Administrator")]
    public class BankController : Controller
    {
        private readonly AppDbContext context;

        public BankController(AppDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Bancos.ToList().OrderBy(x => x.Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CreateBankViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var email = ((ClaimsIdentity)User.Identity!).Claims.Where(c => c.Type == ClaimTypes.Email).Select(c => c.Value).FirstOrDefault()!;

            Banks banco = new Banks(model);
            banco.CreatedBy = context.Usuarios.FirstOrDefault(u => u.Email.ToUpper().Equals(email.ToUpper()))!.Id;
            banco.CreatedOn = DateTimeOffset.Now;

            context.Bancos.Add(banco);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Banks banco = context.Bancos.Find(id)!;

            if (banco == null)
                return NotFound();

            return View(new EditBankViewModel(banco));
        }

        [HttpPost]
        public IActionResult Edit(EditBankViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            Banks banco = context.Bancos.Find(model.Id)!;

            banco.Description = model.Description;
            banco.IsActive = model.IsActive;

            context.Entry(banco).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            Banks bank = context.Bancos.Find(id)!;

            if (bank == null)
                return NotFound();

            context.Bancos.Remove(bank);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
