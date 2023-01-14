using Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace Backend;

public class TodoDbContext : DbContext
{
    public TodoDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<TodoItem> TodoItems { get; set; }
}