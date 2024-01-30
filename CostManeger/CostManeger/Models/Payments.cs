using CostManeger.Models.ViewModels.Payment;
using System.ComponentModel.DataAnnotations;

namespace CostManeger.Models
{
    public class Payments
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Value { get; set; } = 0;
        public DateTimeOffset PaidOn { get; set; }
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;
        public int UserId { get; set; }
        public int InstallmentId { get; set; }
        public int BankId { get; set; }


        public Installments Installment { get; set; } = null!;
        public Banks Bank { get; set; } = null!;
        public Users User { get; set; } = null!;

        public Payments()
        {
            
        }

        public Payments(CreatePaymentViewModel model)
        {
            Name = model.Name;
            Description = model.Description;
            Value = model.Value;
            PaidOn = model.PaidOn;
        }
    }
}
