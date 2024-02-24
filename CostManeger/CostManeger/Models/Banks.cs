using CostManeger.Models.ViewModels.Bank;

namespace CostManeger.Models
{
    public class Banks
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
        public int CreatedBy { get; set; }
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;

        public Banks()
        {
            
        }

        public Banks(BankViewModel model)
        {
            Description = model.Description;
            IsActive = model.IsActive;
        }
    }
}
