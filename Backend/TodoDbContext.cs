using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend;

public class TodoDbContext : DbContext
{
    public DbSet<TodoItem> TodoItems { get; set; }
}