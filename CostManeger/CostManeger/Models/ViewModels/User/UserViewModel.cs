using CostManeger.Models;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CostManeger.Models.ViewModels.User
{
    public class UserViewModel
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "Nome obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Deve conter entre 3 e 50 caracteres!")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Sobrenome")]
        [Required(ErrorMessage = "Sobrenome obrigatório!")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Deve conter entre 3 e 50 caracteres!")]
        public string Surname { get; set; } = string.Empty;

        [DisplayName("E-mail")]
        [Required(ErrorMessage = "E-mail obrigatório!")]
        [EmailAddress(ErrorMessage = "Deve ser um e-mail valido.")]
        public string Email { get; set; } = string.Empty;

        [DisplayName("Telefone")]
        [Required(ErrorMessage = "Telefone obrigatório!")]
        [RegularExpression("\\([0-9]{2}\\) [0-9]{1} [0-9]{4}-[0-9]{4}", ErrorMessage = "Formato inválido. Ex:(XX) X XXXX-XXXX")]
        [Phone(ErrorMessage = "Deve ser um Telefone valido.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [DisplayName("Data de nascimento")]
        [Required(ErrorMessage = "Data de nascimento obrigatória!")]
        public DateTimeOffset BirthDate { get; set; }

        [DisplayName("CPF")]
        public string? CPF { get; set; } = string.Empty;

        [DisplayName("RG")]
        public string? RG { get; set; } = string.Empty;

        [DisplayName("Perfil")]
        [Required(ErrorMessage = "Perfil obrigatório!")]
        [Range(1, 3, ErrorMessage = "Selecione um perfil valido!")]
        public int Profile { get; set; }

        //[DisplayName("Senha")]
        //[Required(ErrorMessage = "Senha obrigatória!")]
        //[StringLength(255, MinimumLength = 8, ErrorMessage = "Deve ter entre 8 e 100 caracteres.")]
        //public string Password { get; set; } = string.Empty;

        //[DisplayName("Senha de confirmação")]
        //[Required(ErrorMessage = "Senha obrigatória!")]
        //[StringLength(255, MinimumLength = 8, ErrorMessage = "Deve ter entre 8 e 100 caracteres.")]
        //[Compare(nameof(Password), ErrorMessage = "Senhas não conferem.")]
        //public string PasswordConfirmed { get; set; } = string.Empty;


        public UserViewModel()
        {

        }

        public UserViewModel(Usuario usuario)
        {
            Name = usuario.Name;
            Surname = usuario.Surname;
            Email = usuario.Email;
            PhoneNumber = usuario.Phone;
            BirthDate = usuario.BirthDate;
            CPF = usuario.CPF;
            RG = usuario.RG;
            Profile = usuario.Profile;
        }
    }
}
