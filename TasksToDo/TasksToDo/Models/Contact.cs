namespace TasksToDo.Models
{
    public class Contact
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public bool IsPersonal { get; set; } = false;
        public bool IsActive { get; set; } = false;
        public User? User { get; set; }
    }
}
