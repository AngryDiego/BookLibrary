using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Data;
using BookLibrary.Models;
namespace BookLibrary.Pages;

public class IndexModel : PageModel
{
    private readonly LibraryContext _context;

    public IndexModel(LibraryContext context)
    {
        _context = context;
    }

    public List<Book> Books { get; set; }

    // GET - return info OPERATION
    // POST - process with data OPERATION
    
    // async methods GET/POST 
    // TASK - class for async methods/operations
    
    public async Task OnGetAsync()
    {
        Books = await _context.BookShelf.ToListAsync();
    }
}