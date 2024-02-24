using CostManeger.Database;
using CostManeger.Models;
using CostManeger.Models.ViewModels.Payment;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CostManeger.Controllers
{
    [Authorize]
    public class PaymentController : Controller
    {
        private readonly AppDbContext context;

        public PaymentController(AppDbContext _context)
        {
            context = _context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(context.Pagamentos.ToList().OrderBy(x => x.Id));
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["BankList"] = context.Bancos.Where(b => b.IsActive == true).ToList().OrderBy(x => x.Id);
            ViewData["InsallmetsList"] = context.Parcelamento.Where(b => b.IsActive == true).ToList().OrderBy(x => x.Id);

            return View();
        }

        [HttpPost]
        public IActionResult Create(PaymentViewModel model)
        {
            ViewData["BankList"] = context.Bancos.Where(b => b.IsActive == true).ToList().OrderBy(x => x.Id);
            ViewData["InsallmetsList"] = context.Parcelamento.Where(b => b.IsActive == true).ToList().OrderBy(x => x.Id);

            if (!ModelState.IsValid)
                return View(model);

            Payments payment = new Payments(model);
            payment.BankId = model.BankId;
            payment.InstallmentId = model.InstallmentId;
            payment.CreatedOn = DateTimeOffset.Now;

            context.Pagamentos.Add(payment);
            context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }
    }
}
