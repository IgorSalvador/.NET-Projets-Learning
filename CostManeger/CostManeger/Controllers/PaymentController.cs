using CostManeger.Database;
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

        public IActionResult Index()
        {
            return View(context.Pagamentos.ToList().OrderBy(x => x.Id));
        }
    }
}
