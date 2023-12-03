using System.ComponentModel.DataAnnotations;

namespace TodoList.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        public DateTime Date { get; set; }
        public bool? IsCompleted { get; set; }

        public Todo()
        {
            
        }

        public Todo(string title, string description, DateTime date, bool isCompleted = false)
        {
            Title = title;
            Description = description;
            Date = date;
            IsCompleted = isCompleted;
        }

        public Todo(int id, string title, string description, DateTime date, bool isCompleted = false)
        {
            Id = id;
            Title = title;
            Description = description;
            Date = date;
            IsCompleted = isCompleted;
        }
    }
}
