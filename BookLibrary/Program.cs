using Microsoft.EntityFrameworkCore;
using BookLibrary.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();
builder.Services.AddDbContext<LibraryContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("LibraryDb")));
var app = builder.Build();

app.MapRazorPages();

app.Run();