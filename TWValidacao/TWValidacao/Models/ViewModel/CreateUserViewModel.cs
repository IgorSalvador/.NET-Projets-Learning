using System.ComponentModel.DataAnnotations;
using TWValidacao.Attributes;

namespace TWValidacao.Models.ViewModel
{
    public class CreateUserViewModel
    {
        [Required(ErrorMessage = "É obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Deve ter entre 3 e 100 caracteres.")]
        public string FirstName { get; set; } = string.Empty;

        [Required(ErrorMessage = "É obrigatório.")]
        [StringLength(100, MinimumLength = 3, ErrorMessage = "Deve ter entre 3 e 100 caracteres.")]
        public string LastName { get; set; } = string.Empty;

        [Required(ErrorMessage = "É obrigatório.")]
        [StringLength(255, ErrorMessage = "Deve ter no máximo 255 caracteres.")]
        [EmailAddress(ErrorMessage = "Deve ser um e-mail valido.")]
        public string Email { get; set; } = string.Empty;

        [Required(ErrorMessage = "É obrigatório.")]
        [AgeBetween(100, 18, ErrorMessage = "Deve possuir entre 18 e 100 anos.")]
        public DateTime BirthDate { get; set; }

        [Required(ErrorMessage = "É obrigatório.")]
        [RegularExpression("\\([0-9]{2}\\) [0-9]{1} [0-9]{4}-[0-9]{4}", ErrorMessage = "Formato inválido. Ex:(XX) X XXXX-XXXX")]
        [Phone(ErrorMessage = "Deve ser um telefone valido.")]
        public string PhoneNumber { get; set; } = string.Empty;

        [Required(ErrorMessage = "É obrigatório.")]
        [Url(ErrorMessage = "Deve ser uma URL valida.")]
        public string ProfilePicture { get; set; } = string.Empty;

        [Required(ErrorMessage = "É obrigatório.")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Deve ter entre 8 e 100 caracteres.")]
        public string Password { get; set; } = string.Empty;

        [Required(ErrorMessage = "É obrigatório.")]
        [StringLength(255, MinimumLength = 8, ErrorMessage = "Deve ter entre 8 e 100 caracteres.")]
        [Compare(nameof(Password), ErrorMessage = "Senhas não conferem.")]
        public string PasswordConfirmation { get; set; } = string.Empty;
    }
}
