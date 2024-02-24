using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CostManeger.Models.ViewModels.Payment
{
    public class PaymentViewModel
    {
        [DisplayName("Nome")]
        [Required(ErrorMessage = "O campo Nome é obrigatório.")]
        [StringLength(100, MinimumLength = 5, ErrorMessage = "O campo Nome deve conter entre 5 e 100 caracteres.")]
        public string Name { get; set; } = string.Empty;

        [DisplayName("Descrição")]
        [Required(ErrorMessage = "O campo Descrição é obrigatório.")]
        [StringLength(500, MinimumLength = 5, ErrorMessage = "O campo Descrição deve conter entre 5 e 500 caracteres.")]
        public string Description { get; set; } = string.Empty;

        [DisplayName("Valor")]
        [Required(ErrorMessage = "O campo Valor é obrigatório.")]
        [Range(0.1, double.MaxValue, ErrorMessage = "O campo de valor deve ser ao menos 0..1")]
        public decimal Value { get; set; } = 0;

        [DisplayName("Data Pagamento")]
        [Required(ErrorMessage = "O campo Data Pagamento é obrigatório.")]
        public DateTimeOffset PaidOn { get; set; } = DateTimeOffset.Now;

        [DisplayName("Banco")]
        [Required(ErrorMessage = "O campo Banco é obrigatório.")]
        public int BankId { get; set; }

        [DisplayName("Parcelas")]
        [Required(ErrorMessage = "O campo Parcelas é obrigatório.")]
        public int InstallmentId { get; set; }
    }
}
