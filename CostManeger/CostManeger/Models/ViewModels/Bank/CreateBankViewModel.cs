using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CostManeger.Models.ViewModels.Bank
{
    public class CreateBankViewModel
    {
        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo descrição é obrigatório!")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "O campo descrição deve conter entre 4 e 100 caracteres.")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Status")]
        public bool IsActive { get; set; } = false;
    }
}
