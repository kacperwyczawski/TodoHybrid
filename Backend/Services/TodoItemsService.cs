using Backend.Errors;
using Backend.Models;

namespace Backend.Services;

public class TodoItemsService
{
    private readonly TodoDbContext _context;

    public TodoItemsService(TodoDbContext context)
    {
        _context = context;
    }
    
    public void Create(string title)
    {
        _context.TodoItems.Add(new TodoItem(title));
        _context.SaveChanges();
    }

    public TodoItem Get(Guid id) =>
        _context.TodoItems.Find(id) ?? throw new NotFoundException($"Todo item with id: {id} not found");
    
    public IEnumerable<TodoItem> GetAll() => _context.TodoItems;
    
    public void Complete(Guid id)
    {
        var todoItem = Get(id);
        _context.TodoItems.Remove(todoItem);
        _context.SaveChanges();
    }
}