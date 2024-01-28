namespace CostManeger.Models
{
    public class Installments
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; } = true;
    }
}
