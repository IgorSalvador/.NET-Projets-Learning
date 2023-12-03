namespace TodoList.Models.ViewModels
{
    public class ListTodoViewModel
    {
        public ICollection<Todo> Todos { get; set; } = new List<Todo>();
    }
}
