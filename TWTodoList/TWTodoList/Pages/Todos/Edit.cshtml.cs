using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TWTodoList.Data;
using TWTodoList.Models;

namespace TWTodoList.Pages.Todos
{
    [BindProperties]
    public class EditModel : PageModel
    {
        public Todo Todo { get; set; } = null!;
        private readonly AppDbContext _context;

        public EditModel(AppDbContext context)
        {
            _context = context;
        }


        public IActionResult OnGet(int id)
        {
            ViewData["Title"] = "Editar Tarefa";
            var todo = _context.Todos.Find(id);

            if(todo == null)
                return NotFound();

            this.Todo = todo;

            return Page();
        }

        public IActionResult OnPost(int id)
        {
            var todo = _context.Todos.Find(id);

            if (todo == null)
                return NotFound();

            todo.Title = Todo.Title;
            todo.Date = Todo.Date;

            _context.Entry(todo).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}
