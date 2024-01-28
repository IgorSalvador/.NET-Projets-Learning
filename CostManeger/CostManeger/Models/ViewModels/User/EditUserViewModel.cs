using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CostManeger.Models.ViewModels.User
{
    public class EditUserViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

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
        public DateTimeOffset BirthDate { get; set; } = DateTimeOffset.Now;

        [DisplayName("CPF")]
        public string? CPF { get; set; } = string.Empty;

        [DisplayName("RG")]
        public string? RG { get; set; } = string.Empty;

        [DisplayName("Perfil")]
        [Required(ErrorMessage = "Perfil obrigatório!")]
        [Range(1, 3, ErrorMessage = "Selecione um perfil valido!")]
        public int Profile { get; set; }

        [DisplayName("Status")]
        public bool IsActive { get; set; }

        public EditUserViewModel()
        {

        }

        public EditUserViewModel(Usuario usuario)
        {
            Id = usuario.Id;
            Name = usuario.Name;
            Surname = usuario.Surname;
            Email = usuario.Email;
            PhoneNumber = usuario.Phone;
            BirthDate = usuario.BirthDate;
            CPF = usuario.CPF;
            RG = usuario.RG;
            Profile = usuario.Profile;
            IsActive = usuario.IsActive;
        }
    }
}
