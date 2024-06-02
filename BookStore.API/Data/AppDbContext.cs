using BookStore.API.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStore.API.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    public DbSet<Book> Books { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>()
            .Property(b => b.Id)
            .ValueGeneratedOnAdd();
    }
}