﻿namespace TodoList.Models.ViewModels
{
    public class CreateTodoViewModel
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; }
    }
}
