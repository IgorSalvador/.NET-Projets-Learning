using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CostManeger.Models.ViewModels.Login
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "O campo de nome de usuário é obrigatório!")]
        [EmailAddress(ErrorMessage = "Nome de usuário inválido.")]
        [DisplayName("Usuário")]
        public string Username { get; set; }

        [Required(ErrorMessage = "O campo de senha é obrigatório!")]
        [DisplayName("Senha")]
        public string Password { get; set; }
    }
}
