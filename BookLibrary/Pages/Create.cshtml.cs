using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookLibrary.Data;
using BookLibrary.Models;
namespace BookLibrary.Pages;

public class CreateModel : PageModel
{
    private readonly LibraryContext _context;

    public CreateModel(LibraryContext context)
    {
        _context = context;
    }
    
    [BindProperty]
    public Book newBook { get; set; }

    public void OnGet()
    {
        
    }
    // OPERATION WITH RETURN - not Task, it's Task<IActionResult>

    public async Task<IActionResult> OnPostAsync()
    {
        _context.BookShelf.Add(newBook);
        await _context.SaveChangesAsync();
        return RedirectToPage("Index");
    }
}