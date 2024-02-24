using Microsoft.AspNetCore.Mvc;
using RequestResponse.Models;

namespace RequestResponse.Controllers
{
    public class TesteController : Controller
    {
        public IActionResult Index()
        {
            Produto produto = new Produto
            {
                Id = 1,
                Nome = "Notebook",
                Descricao = "Muito bom, confia!!!",
                Valor = 10000
            };

            return new JsonResult(produto);
        }

        public IActionResult Relatorio()
        {
            var file = System.IO.File.ReadAllBytes("C:\\Users\\igors\\Downloads\\CV.pdf");

            return File(file, "application/pdf", "myCvTeste.pdf");
        }

        public IActionResult GetFromQuery([FromQuery(Name = "nome")] string name)
        {
            Console.WriteLine(name);

            return View();
        }
    }
}
