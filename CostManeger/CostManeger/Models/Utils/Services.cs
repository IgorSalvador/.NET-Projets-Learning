using CostManager.Models;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;

namespace CostManeger.Models.Utils
{
    public class Services
    {
        public async Task Login(HttpContext ctx, Usuario usuario)
        {
            List<Claim> claims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, usuario.Email),
                new Claim(ClaimTypes.Name, usuario.Name),
                new Claim(ClaimTypes.Role, ProfileOptins.GetProfileDescription(usuario.Profile))
            };

            var claimIdentity = new ClaimsPrincipal(
                new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme));

            var authProperties = new AuthenticationProperties
            {
                ExpiresUtc = DateTime.Now.AddHours(1),
                IssuedUtc = DateTime.Now
            };

            await ctx.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimIdentity, authProperties);
        }

        public async Task SignOut(HttpContext ctx)
        {
            await ctx.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }
    }
}
