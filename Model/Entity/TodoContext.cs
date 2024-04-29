using Microsoft.EntityFrameworkCore;

namespace BlazorApp1.Model.Entity
{
    public class TodoContext : DbContext
    {
        public DbSet<ToDoItem> TodoItems { get; set; }
        public TodoContext(DbContextOptions<TodoContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ToDoItem>().HasData(new List<ToDoItem>{
             new ToDoItem{ Description = "Complete all Coded Assignments", IsCompleted = false, Id = 1, DueDate = new DateTime(2024,04,30)},
             new ToDoItem{ Description = "Appartment Rent", IsCompleted = true, Id = 2},
             new ToDoItem{ Description = "Clean My Room", IsCompleted = false, Id = 3}
 });

        }
    }

}


