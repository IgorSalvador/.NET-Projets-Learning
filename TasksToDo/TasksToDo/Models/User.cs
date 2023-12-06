namespace TasksToDo.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public int Role { get; set; } = 0;
        public DateTime CreatedOn { get; set; } = DateTime.Now;
        public bool MustChangePassword { get; set; } = true;
        public bool IsActive { get; set; } = true;
        public ICollection<Contact>? Contacts { get; set; }
        public ICollection<Task>? Tasks { get; set; }
    }
}
