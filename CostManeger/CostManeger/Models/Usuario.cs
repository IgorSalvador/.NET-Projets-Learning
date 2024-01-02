namespace CostManeger.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public DateTimeOffset BirthDate { get; set; }
        public string? CPF { get; set; }
        public string? RG { get; set; }
        public DateTimeOffset CreateOn { get; set; } = DateTimeOffset.Now;
        public int Profile { get; set; } = 0;
        public bool IsActive { get; set; }
    }
}
