namespace Backend.Models;

public class TodoItem : ITodoItem
{
    public TodoItem(string title)
    {
        Title = title;
    }

    public Guid Id { get; } = Guid.NewGuid();
    public string Title { get; set; }
}