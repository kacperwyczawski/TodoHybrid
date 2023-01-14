using System.ComponentModel.DataAnnotations;

namespace Backend.Models;

public class TodoItem : ITodoItem
{
    public TodoItem(string title)
    {
        Title = title;
    }

    [Key] public Guid Id { get; init; }
    public string Title { get; set; }
}