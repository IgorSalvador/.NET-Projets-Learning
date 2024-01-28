using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace CostManeger.Models.ViewModels.Bank
{
    public class EditBankViewModel
    {
        [DisplayName("Id")]
        public int Id { get; set; }

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório!")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "O campo descrição deve conter entre 4 e 100 caracteres.")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Status")]
        public bool IsActive { get; set; } = false;

        public EditBankViewModel()
        {
            
        }

        public EditBankViewModel(Banks bank)
        {
            Id = bank.Id;
            Description = bank.Description;
            IsActive = bank.IsActive;
        }
    }
}
