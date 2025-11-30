namespace BookLibrary.Data;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Models;

public class LibraryContext : DbContext
{
    // констуркор - public *className*(parametr) : base(parametr), де base - підключення наслідування
    public LibraryContext(DbContextOptions<LibraryContext> options) : base(options)
    {
        
    }

    public DbSet<Book> BookShelf { get; set; }
    

}