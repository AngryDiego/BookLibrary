using Microsoft.EntityFrameworkCore;
using BookLibrary.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<LibraryContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("LibraryDb")));
builder.Services.AddRazorPages();
var app = builder.Build();

app.MapRazorPages();

app.Run();