using Microsoft.EntityFrameworkCore;
using TodoListAPI.Models;

namespace TodoListAPI.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options) {

    }
    public DbSet<TodoItem> TodoItems {get; set;} = null!;
}