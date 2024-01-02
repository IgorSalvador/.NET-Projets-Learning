namespace CostManeger.Models
{
    public class Perfis
    {
        public int Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public bool IsActive { get; set; }
        public DateTimeOffset CreatedOn { get; set; } = DateTimeOffset.Now;
    }
}
