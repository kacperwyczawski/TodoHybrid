namespace Backend.Models;

public interface ITodo
{
    int Id { get; set; }
    string Title { get; set; }
    bool IsDone { get; set; }
}