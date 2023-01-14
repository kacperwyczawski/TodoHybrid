namespace Backend.Models;

public interface ITodoItem
{
    Guid Id { get; }
    string Title { get; set; }
}