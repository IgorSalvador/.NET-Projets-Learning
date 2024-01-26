using CostManeger.Database;
using CostManeger.Models;
using CostManeger.Models.Utils;
using CostManeger.Models.ViewModels.Login;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;
using System.Security.Claims;

namespace CostManeger.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration _configuration;
        private readonly AppDbContext _db;

        public HomeController(ILogger<HomeController> logger, AppDbContext db, IConfiguration configuration)
        {
            _logger = logger;
            _db = db;
            _configuration = configuration;
        }

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        [AllowAnonymous]
        public IActionResult Login(bool errorLogin = false)
        {
            if (HttpContext.User.Identity != null && HttpContext.User.Identity.IsAuthenticated)
                return RedirectToAction(nameof(Index));

            if (errorLogin)
                ViewData["ErrorLogin"] = "Usuário ou senha inválidos";

            return View();
        }

        [HttpPost, AllowAnonymous]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            if (!ModelState.IsValid)
            {
                return View(loginViewModel);
            }

            string encryptedPassword = MD5Encryption.GetMD5Hash(loginViewModel.Password);

            Usuario usuario = _db.Usuarios.Where(u => u.Email.ToUpper().Equals(loginViewModel.Username.ToUpper()) && u.Password.ToUpper().Equals(encryptedPassword.ToUpper())).FirstOrDefault();

            if(usuario == null)
            {
                return RedirectToAction(nameof(Login), new { errorLogin = true});
            }

            await new Services().SignIn(HttpContext, usuario);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet, Authorize]
        public async Task<IActionResult> LogOut()
        {
            await new Services().SignOut(HttpContext);

            return RedirectToAction(nameof(Login));
        }

        [HttpGet, Authorize]
        public IActionResult AccessDenied()
        {
            return View();
        }

        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
