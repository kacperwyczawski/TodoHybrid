namespace Backend.Models;

public class Todo : ITodo
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public bool IsDone { get; set; }
}